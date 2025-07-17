using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class ExportMap : Transferible<ExportMap>
    {
        public int ExportCount;
        public List<FObjectExport> ObjectExports;

        public FObjectExport this[int index]
        {
            get => ObjectExports[index];
            set => ObjectExports[index] = value;
        }

        public int Count => ObjectExports?.Count ?? 0;

        public ExportMap() { }

        public ExportMap(int exportCount)
        {
            ExportCount = exportCount;
        }

        public override ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ObjectExports, ExportCount);
            return this;
        }
    }

    public class ExportMapJsonConverter : JsonConverter<ExportMap>
    {
        public override ExportMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var list = jsonDoc.Deserialize<List<FObjectExport>>(options);
            ExportMap obj = new(list.Count) { ObjectExports = list };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, ExportMap value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.ObjectExports.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
