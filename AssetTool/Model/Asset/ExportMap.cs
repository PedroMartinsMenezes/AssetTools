using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class ExportMap : Transferible<ExportMap>
    {
        private readonly FPackageFileSummary PackageFileSummary;
        public List<FObjectExport> ObjectExports = [];

        public ExportMap(FPackageFileSummary PackageFileSummary)
        {
            this.PackageFileSummary = PackageFileSummary;
        }

        public override ITransferible Move(Transfer transfer)
        {
            ObjectExports.Resize(transfer, PackageFileSummary.ExportCount);
            ObjectExports.ForEach(x => x.Move(transfer));
            return this;
        }
    }

    public class ExportMapJsonConverter : JsonConverter<ExportMap>
    {
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
            using var jsonDoc = JsonDocument.Parse(value.ObjectExports.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
