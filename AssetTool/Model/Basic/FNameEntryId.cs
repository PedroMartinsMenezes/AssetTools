using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FNameEntryId
    {
        public UInt32 Value;

        public object Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
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
