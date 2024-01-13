using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FNameEntrySerialized
    {
        public FString Name = new();
        public UInt16[] DummyHashes = [0, 0];
    }

    public static class FNameEntrySerializedExt
    {
        public static void Write(this BinaryWriter writer, FNameEntrySerialized item)
        {
            writer.Write(item.Name);
            writer.Write(item.DummyHashes[0]);
            writer.Write(item.DummyHashes[1]);
        }

        public static FNameEntrySerialized Read(this BinaryReader reader, FNameEntrySerialized item)
        {
            reader.Read(item.Name);
            reader.Read(ref item.DummyHashes[0]);
            reader.Read(ref item.DummyHashes[1]);
            return item;
        }

        public static List<FNameEntrySerialized> ReadNameMap(this BinaryReader reader, int offset, int count)
        {
            reader.BaseStream.Position = offset;
            return Enumerable.Range(0, count).Select(x => reader.Read(new FNameEntrySerialized())).ToList();
        }
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
