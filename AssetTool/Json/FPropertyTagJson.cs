using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FObjectPropertyBaseJson
    {
        public string Name;
        public UInt32 Value;

        public FObjectPropertyBaseJson(string name, UInt32 value)
        {
            Name = name;
            Value = value;
        }
    }

    public class FObjectPropertyBaseJsonJsonConverter : JsonConverter<FObjectPropertyBaseJson>
    {
        public override FObjectPropertyBaseJson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.Read();
            string name = reader.GetString().Split(' ')[1];
            reader.Read();
            UInt32 value = reader.GetUInt32();
            reader.Read();
            return new FObjectPropertyBaseJson(name, value);

        }
        public override void Write(Utf8JsonWriter writer, FObjectPropertyBaseJson value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteNumber($"obj {value.Name}", value.Value);
            writer.WriteEndObject();
        }
    }
}
