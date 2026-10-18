"""Verifica se os arquivos .cs de AssetTool/UE espelham os arquivos C++ da Unreal Engine.

Regras:
  - AssetTool/UE/<Runtime|Editor|Developer|...>/X.cs  <->  Engine/Source/<...>/X.h|.cpp
  - AssetTool/UE/Plugins/X.cs                         <->  Engine/Plugins/X.h|.cpp
  - AssetTool/UE/Shaders/X.cs                         <->  Engine/Shaders/X.h|.usf|.ush
  - Pasta com nome X.h (ou X.cpp): cada Classe.cs dentro dela deve ter a classe/struct/enum/using
    "Classe" declarada no X.h correspondente. Um X.h/X.cs guarda o conteudo geral do header.
  - Arquivos com [NonUnreal] ou [Removed] sao ignorados.

Gera corretos.txt, incorretos.txt e ignorados.txt na pasta de saida. Para os incorretos, indica
em qual .h da engine (Source ou Plugins, sem ThirdParty) a classe foi encontrada.
Retorna 1 se houver arquivos incorretos.

Uso: python Scripts/check-ue-mapping.py [--engine C:/Epic/UE_5.7/Engine] [--out <pasta>]
"""
import argparse
import os
import re
import sys
from collections import defaultdict

REPO = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CS = os.path.join(REPO, 'AssetTool', 'UE')
SOURCE_ROOTS = ('Runtime', 'Editor', 'Developer', 'Programs', 'ThirdParty')
EXTS = ('.h', '.cpp', '.inl', '.usf', '.ush')
MACROS = r'(?:\w+\s*\((?:[^()]|\([^()]*\))*\)\s+)*(?:\w+_API\s+)?'


def to_engine_path(parts):
    return ('Source/' if parts[0] in SOURCE_ROOTS else '') + '/'.join(parts)


def rel_path(path, root):
    return os.path.relpath(path, root).replace(os.sep, '/')


def read(path):
    with open(path, encoding='utf-8-sig', errors='ignore') as f:
        return f.read()


def index_engine_files(eng):
    idx = defaultdict(list)
    for root in ('Source', 'Plugins', 'Shaders'):
        for dp, _, fn in os.walk(os.path.join(eng, root)):
            for f in fn:
                b, e = os.path.splitext(f)
                if e.lower() in EXTS:
                    idx[b.lower()].append(rel_path(os.path.join(dp, f), eng))
    return idx


def check(eng):
    idx = index_engine_files(eng)
    sources = {}

    def declares(path, name):
        if path not in sources:
            sources[path] = read(os.path.join(eng, path))
        decl = r'\b(?:class|struct|enum(?:\s+class)?)\s+' + MACROS + re.escape(name) + r'\b(?!\s*;)'
        alias = r'\busing\s+' + re.escape(name) + r'\b[^;]*='
        return re.search(decl, sources[path]) is not None or re.search(alias, sources[path]) is not None

    ok, bad, ignored = [], [], []
    for dp, _, fn in os.walk(CS):
        for f in fn:
            if not f.endswith('.cs'):
                continue
            rel = rel_path(os.path.join(dp, f), CS)
            m = re.search(r'\[\s*(NonUnreal|Removed)(?:Attribute)?\s*[\],(]', read(os.path.join(dp, f)))
            if m:
                ignored.append(f"{rel}  [{m.group(1)}]")
                continue

            parts = rel[:-3].split('/')
            hi = next((i for i, c in enumerate(parts[:-1]) if c.lower().endswith(('.h', '.cpp'))), None)
            if hi is not None:
                header = to_engine_path(parts[:hi + 1])
                name = parts[-1]
                if not os.path.isfile(os.path.join(eng, header)):
                    bad.append((rel, f"pasta {parts[hi]} sem arquivo C++ correspondente: {header}"))
                elif hi == len(parts) - 2 and name == os.path.splitext(parts[hi])[0]:
                    ok.append((rel, header))
                elif declares(header, name):
                    ok.append((rel, f"{header} :: {name}"))
                else:
                    bad.append((rel, f"{name} nao declarado em {header}"))
                continue

            target = to_engine_path(parts)
            same_name = idx[parts[-1].lower()]
            hits = [t for t in same_name if os.path.splitext(t)[0] == target]
            if hits:
                ok.append((rel, ', '.join(hits)))
            elif same_name:
                bad.append((rel, 'candidatos: ' + ', '.join(same_name)))
            else:
                bad.append((rel, 'nenhum .h/.cpp com esse nome'))
    return sorted(ok), sorted(bad), sorted(ignored)


def find_declarations(eng, rels):
    """Procura em quais .h da engine as classes dos .cs incorretos sao declaradas."""
    names = {}
    for r in rels:
        stem = os.path.basename(r)[:-3]
        decl = re.findall(r'\b(?:class|struct|enum)\s+(\w+)', read(os.path.join(CS, r)))
        cands = [stem] + ([p + stem for p in 'FUA'] if not re.match(r'[FUA][A-Z]', stem) else [])
        names[r] = list(dict.fromkeys(cands + [d for d in decl if d == stem or d[1:] == stem]))
    allnames = sorted({n for v in names.values() for n in v}, key=len, reverse=True)
    if not allnames:
        return {}
    rx = re.compile(r'^\s*(?:class|struct|enum(?:\s+class)?|using)\s+' + MACROS
                    + '(' + '|'.join(map(re.escape, allnames)) + r')\b(?!\s*;)[^;]*$', re.M)
    found = defaultdict(set)
    for root in ('Source/Runtime', 'Source/Editor', 'Source/Developer', 'Plugins'):
        for dp, _, fn in os.walk(os.path.join(eng, root)):
            if 'ThirdParty' in dp:
                continue
            for f in fn:
                if f.endswith('.h'):
                    p = os.path.join(dp, f)
                    for m in rx.finditer(read(p)):
                        found[m.group(1)].add(rel_path(p, eng))
    return {r: sorted({f"{h} :: {n}" for n in names[r] for h in found[n]}) for r in rels}


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument('--engine', default=r'C:\Epic\UE_5.7\Engine')
    ap.add_argument('--out', default=os.path.join(REPO, 'Scripts', 'ue-mapping'))
    args = ap.parse_args()
    if not os.path.isdir(os.path.join(args.engine, 'Source')):
        sys.exit(f"Pasta da engine invalida: {args.engine}")

    ok, bad, ignored = check(args.engine)
    decls = find_declarations(args.engine, [r for r, _ in bad])

    os.makedirs(args.out, exist_ok=True)
    with open(os.path.join(args.out, 'corretos.txt'), 'w', encoding='utf-8') as o:
        o.write(f"# CORRETAMENTE MAPEADOS ({len(ok)})\n")
        o.writelines(f"{r}  ->  {t}\n" for r, t in ok)
    with open(os.path.join(args.out, 'incorretos.txt'), 'w', encoding='utf-8') as o:
        o.write(f"# INCORRETAMENTE MAPEADOS ({len(bad)})\n")
        for r, reason in bad:
            o.write(f"{r}  ->  {reason}\n")
            for i, d in enumerate(decls.get(r, [])):
                o.write(('        declarado em: ' if i == 0 else ' ' * 22) + d + "\n")
    with open(os.path.join(args.out, 'ignorados.txt'), 'w', encoding='utf-8') as o:
        o.write(f"# IGNORADOS [NonUnreal]/[Removed] ({len(ignored)})\n")
        o.writelines(r + "\n" for r in ignored)

    print(f"Corretos: {len(ok)}  Incorretos: {len(bad)}  Ignorados: {len(ignored)}")
    print(f"Listas em: {args.out}")
    return 1 if bad else 0


if __name__ == '__main__':
    sys.exit(main())
