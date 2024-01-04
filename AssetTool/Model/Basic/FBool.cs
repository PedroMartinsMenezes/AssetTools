using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public struct FBool
    {
        public bool Value;

        public static implicit operator FBool(Int32 value) => new FBool { Value = value == 1 };
    }

    public static class FBoolExt
    {
        public static void Read(this BinaryReader reader, ref FBool item)
        {
            item.Value = reader.ReadInt32() == 1;
        }

        public static void Write(this BinaryWriter writer, FBool item)
        {
            writer.Write(item.Value ? 1 : 0);
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
