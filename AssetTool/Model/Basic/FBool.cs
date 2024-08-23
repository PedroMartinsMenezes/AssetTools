using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FBool
    {
        public FBool() { }

        public FBool(string v) { _value = uint.Parse(v); }

        public FBool(uint v) { _value = v; }

        [JsonIgnore] public bool Value => _value != 0;

        private uint _value;

        public uint GetValue()
        {
            return _value;
        }

        public void SetValue(uint v)
        {
            _value = v;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }

    public class FBoolJsonConverter : JsonConverter<FBool>
    {
        public override FBool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }
            FBool value = new FBool();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return value;
                }
                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException();
                }
                reader.Read();
                uint number = reader.GetUInt32();
                value.SetValue(number);
            }

            throw new JsonException();
        }
        public override void Write(Utf8JsonWriter writer, FBool value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber("Value", value.GetValue());
            writer.WriteEndObject();
        }
    }
}
