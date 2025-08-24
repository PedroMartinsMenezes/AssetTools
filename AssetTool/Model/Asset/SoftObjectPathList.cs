using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("Count = {SoftObjectPathsCount}")]
    public class SoftObjectPathList : ITransferible
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

        public SoftObjectPathList(int softObjectPathsCount)
        {
            SoftObjectPathsCount = softObjectPathsCount;
        }

        public ITransferible Move(Transfer transfer)
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
            SoftObjectPathList obj = new(list.Count) { SoftObjectPaths = list };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, SoftObjectPathList value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.SoftObjectPaths.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}
