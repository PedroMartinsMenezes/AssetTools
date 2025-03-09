using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class UInt16ArrayJsonConverter : JsonConverter<UInt16[]>
    {
        public override UInt16[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string str = reader.GetString();
            return str.Length == 0 ? new UInt16[0] : str.Split(' ').Select(x => UInt16.Parse(x)).ToArray();
        }
        public override void Write(Utf8JsonWriter writer, UInt16[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }
}
