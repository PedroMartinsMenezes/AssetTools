using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class SoftObjectPathList : ITransferible<SoftObjectPathList>
    {
        private readonly FPackageFileSummary PackageFileSummary;
        public List<FSoftObjectPath> SoftObjectPaths = [];

        public SoftObjectPathList(FPackageFileSummary PackageFileSummary)
        {
            this.PackageFileSummary = PackageFileSummary;
        }

        public override void Move(Transfer transfer)
        {
            SoftObjectPaths.Resize(transfer, PackageFileSummary.SoftObjectPathsCount);
            SoftObjectPaths.ForEach(x => x.MoveComplete(transfer));
        }
    }

    public class SoftObjectPathListJsonConverter : JsonConverter<SoftObjectPathList>
    {
        public override SoftObjectPathList Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var list = jsonDoc.Deserialize<List<FSoftObjectPath>>(options);
            var summary = new FPackageFileSummary { SoftObjectPathsCount = list.Count };
            SoftObjectPathList obj = new(summary) { SoftObjectPaths = list };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, SoftObjectPathList value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.SoftObjectPaths.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
