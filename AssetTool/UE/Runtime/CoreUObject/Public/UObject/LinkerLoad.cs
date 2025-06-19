using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public class Ptr : ITransferible
    {
        public UInt32 Value;
        public string TypeName;

        public Ptr(string typeName)
        {
            TypeName = typeName;
        }

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }

        public override string ToString()
        {
            return $"({TypeName}*){Value}";
        }
    }

    public class PtrJsonConverter : JsonConverter<Ptr>
    {
        public override Ptr Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Regex.Match(reader.GetString()!, @"\((\w+)\*\)(\d+)") is Match m ? new Ptr(m.Groups[1].Value) { Value = UInt32.Parse(m.Groups[2].Value) } : null;
        }
        public override Ptr ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, Ptr value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, Ptr value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.ToString());
        }
    }
}
