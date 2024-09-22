using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class ImportMap : ITransferible<ImportMap>
    {
        private readonly FPackageFileSummary PackageFileSummary;
        public List<FObjectImport> ObjectImports = [];

        public ImportMap(FPackageFileSummary PackageFileSummary)
        {
            this.PackageFileSummary = PackageFileSummary;
        }

        public override void Move(Transfer transfer)
        {
            ObjectImports.Resize(transfer, PackageFileSummary.ImportCount);
            ObjectImports.ForEach(x => x.Move(transfer));
        }
    }

    public class ImportMapJsonConverter : JsonConverter<ImportMap>
    {
        public override ImportMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var list = jsonDoc.Deserialize<List<FObjectImport>>(options);
            var summary = new FPackageFileSummary { ImportCount = list.Count };
            ImportMap obj = new(summary) { ObjectImports = list };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, ImportMap value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.ObjectImports.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
