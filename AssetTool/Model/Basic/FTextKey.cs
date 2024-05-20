using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value.Length > 0 ? Value : \"None\"}")]
    public class FTextKey
    {
        public FTextKey() { }

        public FTextKey(string value)
        {
            Value = value;
        }

        [JsonIgnore]
        public int Length => Value.Length + 1;

        public byte[] ToByteArray() => Encoding.ASCII.GetBytes(Value);

        public string Value = string.Empty;

        public override string ToString()
        {
            return Value;
        }
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
