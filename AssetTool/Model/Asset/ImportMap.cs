using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class ImportMap : ITransferible<ImportMap>
    {
        public List<FObjectImport> ObjectImports = [];

        public override void Move(Transfer transfer, int count = 0)
        {
            ObjectImports.Resize(transfer, count);
            ObjectImports.ForEach(x => x.Move(transfer));
        }
    }

    public class ImportMapJsonConverter : JsonConverter<ImportMap>
    {
        public override ImportMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            ImportMap obj = new() { ObjectImports = [] };
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            obj.ObjectImports = jsonDoc.Deserialize<List<FObjectImport>>(options);
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, ImportMap value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.ObjectImports.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
