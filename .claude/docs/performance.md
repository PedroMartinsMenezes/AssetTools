# Performance Analysis — AssetTool

**Data**: 2026-08-16  
**Escopo**: Pasta `AssetTool/` (611 arquivos C#)

---

## Resumo Executivo

Foram identificados **12 problemas de performance e qualidade** distribuídos em diferentes níveis de impacto. Os problemas mais críticos envolvem uso de Reflection em hot paths, resource leaks, e padrões de alocação desnecessária em loops de processamento de assets.

---

## Problemas Identificados

### P0 — Crítico

#### 1. Resource Leak em `DataComparer.CompareFiles()`
- **Arquivo**: `DataComparer.cs` (linhas 7–33)
- **Problema**: `FileStream` criado sem `using`. Se `ReadByte()` lançar exceção ou `Close()` falhar, os file handles vazam. Com volume alto de assets, pode causar exaustão de handles e crash da aplicação.
```csharp
// ATUAL — sem using, sem try/finally
FileStream fs1 = new FileStream(file1, FileMode.Open);
FileStream fs2 = new FileStream(file2, FileMode.Open);
// ...
fs1.Close();
fs2.Close();

// CORRETO
using var fs1 = new FileStream(file1, FileMode.Open);
using var fs2 = new FileStream(file2, FileMode.Open);
```
- **Impacto**: **ALTO** — Instabilidade em pipelines de longa duração.

---

### P1 — Alto

#### 2. Reflection com `Activator.CreateInstance()` em Hot Paths
- **Arquivos**: `FPropertyTag.cs` (linhas 681, 788), `GlobalObjects.cs` (linha 12)
- **Problema**: `Activator.CreateInstance()` chamado em lambdas registradas e executadas a cada asset carregado. Reflection tem overhead 10–100× comparado a construção direta.
```csharp
// ATUAL — FPropertyTag.cs:681
value = ((ITransferableSelector)Activator.CreateInstance(t.Item1)).Move(transfer, num, value);

// ATUAL — GlobalObjects.cs:12
myAsset.Obj = myAsset.Obj ?? (UObject)Activator.CreateInstance(t.Item1);
```
- **Correção**: Criar factory delegates no static constructor e cacheá-los por tipo.
```csharp
// Criar delegate compilado uma única vez no static init
var factory = Expression.Lambda<Func<ITransferableSelector>>(
    Expression.New(t.Item1)).Compile();
StructMovers.Add(t.Item2.TypeName, (transfer, num, value, parentTag) =>
{
    value = factory().Move(transfer, num, value);
    // ...
});
```
- **Impacto**: **ALTO** — Ganho estimado de 10–30% no carregamento de assets em volume.

---

### P2 — Médio-Alto

#### 3. Busca Linear em Dictionary com `FirstOrDefault + Contains`
- **Arquivos**: `TG_Pin.cs`, `TG_Signature.cs`, `Level.cs`, `SkeletalMesh.cs`, `MaterialInstance.cs`
- **Problema**: Busca O(n) em `Dictionary<string, object>` usando `.FirstOrDefault(x => x.Key.Contains(...))`, anulando o benefício do Dictionary.
```csharp
// ATUAL — O(n) por chamada
if (Members.FirstOrDefault(x => x.Key.Contains("'Argument'")).Value is Dictionary<string, object> dict)

// MELHOR — pré-computar lookup no carregamento
// Ou usar chave exata se conhecida em tempo de compilação
```
- **Impacto**: **MÉDIO-ALTO** — Com 100+ membros e 5–10 buscas por asset, resulta em 500–1000 comparações de string por asset.

---

### P3 — Médio

#### 4. `.ToList().ForEach()` Anti-Pattern
- **Arquivos**: `FPropertyTag.cs` (linhas 674, 735, 757), `GlobalObjects.cs` (linha 8), `PolymorphicTypeResolver.cs` (linha 12)
- **Problema**: Aloca uma `List<T>` intermediária desnecessária antes de iterar.
```csharp
// ATUAL — alocação desnecessária
TransferableStructAttribute.TypesAndAttributes.ToList().ForEach(t => { /* ... */ });

// CORRETO — sem alocação
foreach (var t in TransferableStructAttribute.TypesAndAttributes) { /* ... */ }
```
- **Impacto**: **MÉDIO** — Pressão extra no GC durante startup. Mesma coleção é iterada 3 vezes separadamente no static constructor de `FPropertyTag`.

---

#### 5. Lock Segurando Serialização JSON
- **Arquivo**: `JsonSerializerExt.cs` (linhas 57–73)
- **Problema**: `lock` contém chamada a `JsonSerializer.Serialize()`, que é pesada. Se múltiplas threads chegarem ao mesmo ponto, ficam bloqueadas durante a serialização inteira.
```csharp
// ATUAL — serialização dentro do lock
lock (_lock)
{
    json = JsonSerializer.Serialize(self, DefaultOptions);  // PESADO!
    path = transfer.GlobalObjects.FileName.GetTempJsonPath();
}

// MELHOR — apenas acesso a dados compartilhados dentro do lock
string path;
lock (_lock) { path = transfer.GlobalObjects.FileName.GetTempJsonPath(); }
var json = JsonSerializer.Serialize(self, DefaultOptions);
```
- **Impacto**: **MÉDIO** — Gargalo em cenários com processamento paralelo de assets.

---

#### 6. Alocações em Loops de Desserialização Binária
- **Arquivo**: `TransferReader.cs` (linhas 243–273)
- **Problema**: `List<T>` alocada sem capacity conhecida em cada iteração do loop externo, causando múltiplos resizes internos.
```csharp
// ATUAL — sem capacity, causa N resizes por lista
for (int i = 0; i < count; i++)
{
    List<T> value2 = new();
    int count2 = reader.ReadInt32();
    for (int j = 0; j < count2; j++) { value2.Add(item); }
    value.Add(value2);
}

// MELHOR — pré-alocado
for (int i = 0; i < count; i++)
{
    int count2 = reader.ReadInt32();
    List<T> value2 = new(count2);  // sem resizes
    for (int j = 0; j < count2; j++) { value2.Add(item); }
    value.Add(value2);
}
```
- **Impacto**: **MÉDIO** — Com count=1000 e count2=100 médio, são ~100k alocações evitáveis.

---

#### 7. Métodos de Parsing de String Duplicados
- **Arquivo**: `Extensions.cs` (linhas 31–365)
- **Problema**: 10 métodos (`ToByteArray`, `ToInt32Array`, `ToUInt16Array`, etc.) implementam a mesma lógica de parsing com `ReadOnlySpan<char>`, porém cada um faz uma primeira passagem só para contar separadores — redundante.
```csharp
// Padrão repetido 10 vezes: conta separadores, aloca array, parseia
int count = 1;
for (int i = 0; i < span.Length; i++)
    if (span[i] == ' ') count++;
T[] numbers = new T[count];
// ...
```
- **Correção**: Usar `List<T>` durante o parse e `.ToArray()` ao final, ou usar um método genérico `ParseSpaceDelimited<T>`.
- **Impacto**: **MÉDIO** — Código duplicado dificulta manutenção e dobra o trabalho de parsing.

---

#### 8. Closures Capturando Variável de Loop
- **Arquivo**: `FPropertyTag.cs` (linhas 674–749)
- **Problema**: O `ForEach(t => { StructMovers.Add(..., (transfer, num, value, parentTag) => { /* usa t.Item1 */ }); })` cria uma closure por tipo registrado, aumentando pressão no GC.
- **Correção**: Capturar o tipo em variável local antes da lambda interna, ou refatorar para método nomeado.
- **Impacto**: **MÉDIO** — GC pressure em startup; número de closures proporcional ao número de tipos registrados.

---

#### 9. `BitConverter.GetBytes()` + String Replace em Paths de NaN
- **Arquivo**: `Extensions.cs` (linhas 368–378)
- **Problema**: Para `float.IsNaN`, o código cria 3 strings intermediárias: `GetBytes` (byte[]), `ToString` (string com hífens), `Replace` (string final).
```csharp
return $"0x{BitConverter.ToString(BitConverter.GetBytes(self)).Replace("-", "")}";
```
- **Correção**: Usar `Span<byte>` com `stackalloc` e `TryFormat` para evitar alocações de heap.
- **Impacto**: **MÉDIO** — Relevante se o código processa arquivos com muitos valores NaN.

---

### P4 — Baixo

#### 10. `Task.FromResult()` Desnecessário
- **Arquivo**: `AssetPackage.cs` (linha 128)
- **Problema**: Método marcado como `async` que retorna `await Task.FromResult(value)` — a máquina de estados async é criada sem necessidade.
```csharp
// ATUAL
return await Task.FromResult(status.TrueForAll(x => x));

// CORRETO — sem overhead de máquina de estados
return status.TrueForAll(x => x);
// (e remover o modificador async do método)
```
- **Impacto**: **BAIXO** — IL desnecessário, overhead negligível em execução.

---

#### 11. Ausência de `ConfigureAwait(false)`
- **Arquivos**: `JsonSerializerExt.cs`, `AssetPackage.cs`
- **Problema**: Métodos async em library code não usam `.ConfigureAwait(false)`, capturando o `SynchronizationContext` desnecessariamente.
```csharp
// ATUAL
await JsonSerializer.SerializeAsync(ms, self, DefaultOptions);

// MELHOR em library code
await JsonSerializer.SerializeAsync(ms, self, DefaultOptions).ConfigureAwait(false);
```
- **Impacto**: **BAIXO** — Overhead de context capture; irrelevante em contextos sem SynchronizationContext (console/worker).

---

#### 12. Iteração Tripla da Mesma Coleção no Static Constructor
- **Arquivo**: `FPropertyTag.cs` (static constructor)
- **Problema**: `TransferableStructAttribute.TypesAndAttributes` é iterado 3 vezes separadamente para registrar movers, construtores derivados e calculadores de tamanho dinâmico.
- **Correção**: Iterar uma única vez e construir os 3 dicionários simultaneamente.
- **Impacto**: **BAIXO** — Ocorre apenas no startup, mas é sintoma de código difícil de manter.

---

## Tabela de Prioridades

| # | Problema | Arquivo(s) | Severidade | Esforço de Correção |
|---|----------|-----------|-----------|-------------------|
| 1 | FileStream leak | DataComparer.cs | **ALTO** | Muito Baixo |
| 2 | Activator.CreateInstance em hot paths | FPropertyTag, GlobalObjects | **ALTO** | Alto |
| 3 | Dictionary linear search | TG_Pin, TG_Signature, Level, outros | **MÉDIO-ALTO** | Médio |
| 4 | .ToList().ForEach anti-pattern | 5 arquivos | **MÉDIO** | Muito Baixo |
| 5 | Lock segurando serialização | JsonSerializerExt | **MÉDIO** | Baixo |
| 6 | List sem capacity em loops | TransferReader | **MÉDIO** | Muito Baixo |
| 7 | Parsing duplicado 10 vezes | Extensions.cs | **MÉDIO** | Médio |
| 8 | Closures capturando loop var | FPropertyTag | **MÉDIO** | Baixo |
| 9 | BitConverter allocations em NaN | Extensions.cs | **MÉDIO** | Médio |
| 10 | Task.FromResult desnecessário | AssetPackage | **BAIXO** | Muito Baixo |
| 11 | Ausência de ConfigureAwait | JsonSerializerExt, AssetPackage | **BAIXO** | Muito Baixo |
| 12 | Iteração tripla no static ctor | FPropertyTag | **BAIXO** | Baixo |

---

## Sequência Recomendada de Correção

1. **Imediato** — `DataComparer.cs`: trocar para `using var` (1 linha de mudança, elimina risco de crash).
2. **Curto prazo** — Remover `.ToList()` de todos os `.ToList().ForEach()` (5 locais, trivial).
3. **Curto prazo** — Pré-alocar `List<T>` com capacity em `TransferReader.cs`.
4. **Médio prazo** — Substituir `Activator.CreateInstance()` por compiled expression factories.
5. **Médio prazo** — Consolidar os 10 métodos de parsing em `Extensions.cs` em um método genérico.
6. **Longo prazo** — Revisar estratégia de lookup em `Dictionary<string, object>` nos tipos de Blueprint/Level.
