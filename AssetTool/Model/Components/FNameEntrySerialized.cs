using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FNameEntrySerialized
    {
        public FString Name = new();
        public UInt16[] DummyHashes = [0, 0];
    }

    public class FNameEntrySerializedJsonConverter : JsonConverter<FNameEntrySerialized>
    {
        public override FNameEntrySerialized Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var x = reader.GetString()!.Split(',');
            return new FNameEntrySerialized { Name = new FString(x[0]), DummyHashes = [ushort.Parse(x[1]), ushort.Parse(x[2])] };
        }

        public override void Write(Utf8JsonWriter writer, FNameEntrySerialized value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.Name.Value}, {value.DummyHashes[0]}, {value.DummyHashes[1]}");
        }
    }
}
