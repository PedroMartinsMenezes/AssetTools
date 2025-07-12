using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class SoftObjectPathList : Transferible<SoftObjectPathList>
    {
        public int SoftObjectPathsCount;
        public List<FSoftObjectPath> SoftObjectPaths;

        public SoftObjectPathList() { }

        public int Count => SoftObjectPaths?.Count ?? 0;

        public FSoftObjectPath this[int index]
        {
            get => SoftObjectPaths[index];
            set => SoftObjectPaths[index] = value;
        }

        public SoftObjectPathList(FPackageFileSummary PackageFileSummary)
        {
            SoftObjectPathsCount = PackageFileSummary.SoftObjectPathsCount;
        }

        public override ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref SoftObjectPaths, SoftObjectPathsCount, (x) => x.MoveComplete(transfer));
            return this;
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
