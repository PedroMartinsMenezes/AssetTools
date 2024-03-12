using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("FArchive& operator<<(FArchive& Ar, FNameEntrySerialized& E)")]
    public class FNameEntrySerialized
    {
        public FString Name = new();
        public UInt16[] DummyHashes = [0, 0];
    }

    public static class FNameEntrySerializedExt
    {
        public static List<FNameEntrySerialized> Read(this BinaryReader reader, List<FNameEntrySerialized> list, int count)
        {
            list ??= new();
            list.Resize(count);
            list.ForEach(item => reader.Read(item));
            return list;
        }

        public static FNameEntrySerialized Read(this BinaryReader reader, FNameEntrySerialized item)
        {
            item ??= new();
            reader.Read(ref item.Name);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_NAME_HASHES_SERIALIZED))
            {
                reader.Read(ref item.DummyHashes[0]);
                reader.Read(ref item.DummyHashes[1]);
            }
            return item;
        }

        public static void Write(this BinaryWriter writer, List<FNameEntrySerialized> list)
        {
            list.ForEach(writer.Write);
        }

        public static void Write(this BinaryWriter writer, FNameEntrySerialized item)
        {
            writer.Write(item.Name);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_NAME_HASHES_SERIALIZED))
            {
                writer.Write(item.DummyHashes[0]);
                writer.Write(item.DummyHashes[1]);
            }
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
