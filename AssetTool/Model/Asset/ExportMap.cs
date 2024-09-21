using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class ExportMap : ITransferible<ExportMap>
    {
        public List<FObjectExport> ObjectExports = [];

        public override void Move(Transfer transfer, int count = 0)
        {
            ObjectExports.Resize(transfer, count);
            ObjectExports.ForEach(x => x.Move(transfer));
        }
    }

    public class ExportMapJsonConverter : JsonConverter<ExportMap>
    {
        public override ExportMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            ExportMap obj = new() { ObjectExports = [] };
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            obj.ObjectExports = jsonDoc.Deserialize<List<FObjectExport>>(options);
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, ExportMap value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.ObjectExports.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
