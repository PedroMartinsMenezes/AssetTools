using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class GatherableTextDataList : Transferible<GatherableTextDataList>
    {
        private readonly FPackageFileSummary PackageFileSummary;
        public List<FGatherableTextData> GatherableTexts = [];

        public GatherableTextDataList(FPackageFileSummary PackageFileSummary)
        {
            this.PackageFileSummary = PackageFileSummary;
        }

        public override ITransferible Move(Transfer transfer)
        {
            GatherableTexts.Resize(transfer, PackageFileSummary.GatherableTextDataCount);
            GatherableTexts.ForEach(x => x.Move(transfer));
            return this;
        }
    }

    public class GatherableTextDataListJsonConverter : JsonConverter<GatherableTextDataList>
    {
        public override GatherableTextDataList Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var list = jsonDoc.Deserialize<List<FGatherableTextData>>(options);
            var summary = new FPackageFileSummary { GatherableTextDataCount = list.Count };
            GatherableTextDataList obj = new(summary) { GatherableTexts = list };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, GatherableTextDataList value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.GatherableTexts.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
