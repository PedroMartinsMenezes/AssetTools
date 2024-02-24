using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FBool
    {
        public FBool() { }

        public FBool(string v) { Value = v == string.Empty ? false : bool.Parse(v); }

        public bool Value;

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public static class FBoolExt
    {
        public static void Read(this BinaryReader reader, ref FBool item)
        {
            item = reader.ReadInt32() == 1 ? new FBool { Value = true } : null;
        }

        public static FBool ReadFBool(this BinaryReader reader)
        {
            return reader.ReadInt32() == 1 ? new FBool { Value = true } : null;
        }

        public static void Write(this BinaryWriter writer, FBool item)
        {
            writer.Write(item?.Value == true ? 1 : 0);
        }
    }

    public class FBoolJsonConverter : JsonConverter<FBool>
    {
        public override FBool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FBool { Value = bool.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, FBool value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Value.ToString());
        }
    }
}
