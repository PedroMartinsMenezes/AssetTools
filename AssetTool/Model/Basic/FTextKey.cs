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

    public static class FTextKeyExt
    {
        public static void Write(this BinaryWriter writer, FTextKey text)
        {
            writer.Write(text?.Length ?? 0);
            writer.Write(text?.ToByteArray() ?? []);
            writer.Write((byte)0);
        }

        public static FTextKey Read(this BinaryReader reader, ref FTextKey item)
        {
            int size = reader.ReadInt32();
            if (size > 1024)
            {
                throw new InvalidOperationException("FTextKey to big");
            }
            if (size > 0)
            {
                item ??= new();
                byte[] bytes = new byte[size - 1];

                reader.Read(bytes, 0, size - 1);
                _ = reader.ReadByte();

                item.Value = Encoding.ASCII.GetString(bytes);
            }
            return item;
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
