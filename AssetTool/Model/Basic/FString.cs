using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value.Length > 0 ? Value : \"None\"}")]
    public class FString
    {
        public FString() { }

        public FString(string value)
        {
            Value = value;
        }

        [JsonIgnore]
        public int Length => Value.Length > 0 ? Value.Length + 1 : 0;

        public byte[] ToByteArray() => Encoding.ASCII.GetBytes(Value);

        public string Value = string.Empty;
    }

    public static class FStringExt
    {
        public static void Write(this BinaryWriter writer, FString text)
        {
            int length = text?.Length ?? 0;
            writer.Write(length);
            if (length > 0)
            {
                writer.Write(text.ToByteArray());
                writer.Write((byte)0);
            }
        }

        public static FString Read(this BinaryReader reader, FString item)
        {            
            int size = reader.ReadInt32();
            if (size > 0)
            {
                item ??= new();
                byte[] bytes = new byte[size - 1];
                reader.Read(bytes, 0, size - 1);
                string text = Encoding.ASCII.GetString(bytes);
                _ = reader.ReadByte();
                item.Value = text;
            }
            return item;
        }
    }

    public class FStringJsonConverter : JsonConverter<FString>
    {
        public override FString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FString(reader.GetString()!);
        }

        public override void Write(Utf8JsonWriter writer, FString value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Value);
        }
    }
}
