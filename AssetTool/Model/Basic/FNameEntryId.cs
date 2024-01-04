using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FNameEntryId
    {
        public UInt32 Value;
    }

    public static class FNameEntryIdExt
    {
        public static void Write(this BinaryWriter writer, FNameEntryId name)
        {
            writer.Write(name.Value);
        }

        public static void Read(this BinaryReader reader, FNameEntryId item)
        {
            reader.Read(ref item.Value);
        }
    }

    public class FNameEntryIdJsonConverter : JsonConverter<FNameEntryId>
    {
        public override FNameEntryId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FNameEntryId { Value = reader.GetUInt32() };
        }

        public override void Write(Utf8JsonWriter writer, FNameEntryId value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
    }
}
