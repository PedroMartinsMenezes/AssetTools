using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class GatherableTextDataList : ITransferible
    {
        public int GatherableTextDataCount;
        public List<FGatherableTextData> GatherableTexts;

        public GatherableTextDataList() { }

        public GatherableTextDataList(int gatherableTextDataCount)
        {
            GatherableTextDataCount = gatherableTextDataCount;
        }

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref GatherableTexts, GatherableTextDataCount);
            return this;
        }
    }

    public class GatherableTextDataListJsonConverter : JsonConverter<GatherableTextDataList>
    {
        public override GatherableTextDataList Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var list = jsonDoc.Deserialize<List<FGatherableTextData>>(options);
            GatherableTextDataList obj = new(list.Count) { GatherableTexts = list };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, GatherableTextDataList value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.GatherableTexts.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
