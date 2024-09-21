using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class GatherableTextDataList : ITransferible<GatherableTextDataList>
    {
        public List<FGatherableTextData> GatherableTexts = [];

        public override void Move(Transfer transfer, int count = 0)
        {
            GatherableTexts.Resize(transfer, count);
            GatherableTexts.ForEach(x => x.Move(transfer));
        }
    }

    public class GatherableTextDataListJsonConverter : JsonConverter<GatherableTextDataList>
    {
        public override GatherableTextDataList Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            GatherableTextDataList obj = new() { GatherableTexts = [] };
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            obj.GatherableTexts = jsonDoc.Deserialize<List<FGatherableTextData>>(options);
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, GatherableTextDataList value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.GatherableTexts.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
