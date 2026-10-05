using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FTextKey
    {
        public string Value = null;

        public FTextKey() { }

        public FTextKey(string value)
        {
            Value = value == "\\0" ? string.Empty : value == string.Empty ? null : value;
        }

        public override string ToString()
        {
            return Value == string.Empty ? "\\0" : Value;
        }

        [JsonIgnore]
        public int Length => Value is null ? 0 : Value.Length + 1;

        public byte[] ToByteArray() => Encoding.ASCII.GetBytes(Value);
    }

    public class FTextKeyJsonConverter : JsonConverter<FTextKey>
    {
        public override FTextKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FTextKey(reader.GetString()!);
        }

        public override void Write(Utf8JsonWriter writer, FTextKey value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Value);
        }
    }
}
