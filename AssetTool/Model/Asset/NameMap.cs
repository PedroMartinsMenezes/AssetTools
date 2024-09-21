using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class NameMap : ITransferible<NameMap>
    {
        public List<FNameEntrySerialized> NameEntries = [];

        public override void Move(Transfer transfer, int count = 0)
        {
            NameEntries.Resize(transfer, count);
            NameEntries.ForEach(x => x.Move(transfer));
        }
    }

    public class NameMapJsonConverter : JsonConverter<NameMap>
    {
        public override NameMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            NameMap obj = new() { NameEntries = [] };
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    string indices = $"\"{reader.GetString()}\"";
                    FNameEntrySerialized item = indices.ToObject<FNameEntrySerialized>();
                    obj.NameEntries.Add(item);
                }
            }
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, NameMap value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            value.NameEntries.ForEach(x => writer.WriteStringValue($"({x.DummyHashes[0]} {x.DummyHashes[1]}) {x.Name.Value}"));
            writer.WriteEndArray();
        }
    }
}
