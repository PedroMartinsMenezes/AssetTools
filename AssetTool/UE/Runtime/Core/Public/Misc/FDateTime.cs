using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class FDateTime
    {
        public Int64 Ticks;
    }

    public class FDateTimeJsonConverter : JsonConverter<FDateTime>
    {
        public override FDateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new FDateTime { Ticks = Int64.Parse(reader.GetString(), CultureInfo.InvariantCulture) };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FDateTime value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.Ticks}");
            writer.WriteStringValue(s);
        }
    }
}
