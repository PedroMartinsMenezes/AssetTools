using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class ImportMap : ITransferable
    {
        public int ImportCount;
        public List<FObjectImport> ObjectImports;

        public ImportMap() { }

        public ImportMap(int importCount)
        {
            ImportCount = importCount;
        }

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ObjectImports, ImportCount);
            ObjectImports.ForEach(x => x.UpdateIndexes(transfer));
            return this;
        }
    }

    public class ImportMapJsonConverter : JsonConverter<ImportMap>
    {
        public override ImportMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var list = jsonDoc.Deserialize<List<FObjectImport>>(options);
            ImportMap obj = new(list.Count) { ObjectImports = list };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, ImportMap value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.ObjectImports.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
