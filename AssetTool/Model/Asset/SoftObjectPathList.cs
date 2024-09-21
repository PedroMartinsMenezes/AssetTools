using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class SoftObjectPathList : ITransferible<SoftObjectPathList>
    {
        public List<FSoftObjectPath> SoftObjectPaths = [];

        public override void Move(Transfer transfer, int count = 0)
        {
            SoftObjectPaths.Resize(transfer, count);
            SoftObjectPaths.ForEach(x => x.MoveComplete(transfer));
        }
    }

    public class SoftObjectPathListJsonConverter : JsonConverter<SoftObjectPathList>
    {
        public override SoftObjectPathList Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            SoftObjectPathList obj = new() { SoftObjectPaths = [] };
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            obj.SoftObjectPaths = jsonDoc.Deserialize<List<FSoftObjectPath>>(options);
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, SoftObjectPathList value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.SoftObjectPaths.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
