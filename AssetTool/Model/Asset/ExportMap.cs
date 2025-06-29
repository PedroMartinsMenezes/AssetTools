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

        public ExportMap(FPackageFileSummary PackageFileSummary)
        {
            ExportCount = PackageFileSummary.ExportCount;
        }

        public override ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ObjectExports, ExportCount);
            return this;
        }
    }

    public class ExportMapJsonConverter : JsonConverter<ExportMap>
    {
        Transfer transfer;

        public ExportMapJsonConverter SetTransfer(Transfer transfer)
        {
            this.transfer = transfer;
            return this;
        }

        public override ExportMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var list = jsonDoc.Deserialize<List<FObjectExport>>(options);
            var summary = new FPackageFileSummary { ExportCount = list.Count };
            ExportMap obj = new(summary) { ObjectExports = list };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, ExportMap value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.ObjectExports.ToJson(transfer));
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
