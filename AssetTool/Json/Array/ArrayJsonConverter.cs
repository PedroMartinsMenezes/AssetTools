using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class UInt16ArrayJsonConverter : JsonConverter<UInt16[]>
    {
        public override UInt16[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(' ').Select(x => UInt16.Parse(x)).ToArray();
        }
        public override void Write(Utf8JsonWriter writer, UInt16[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }
}
