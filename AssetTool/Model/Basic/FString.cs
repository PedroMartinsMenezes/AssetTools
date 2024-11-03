using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value.Length > 0 ? Value : \"None\"}")]
    public class FString : ITransferible
    {
        public int SizeOf() => 4 + Length;

        public FString() { }

        public FString(string value, bool isUnicode = false)
        {
            Value = value;
            IsUnicode = isUnicode;
        }

        [JsonIgnore] public int Length => IsUnicode ? UnicodeLength : AnsiLength;
        [JsonIgnore] public int AnsiLength => Value.Length > 0 ? Value.Length + 1 : 0;
        [JsonIgnore] public int UnicodeLength => Value.Length > 0 ? Value.Length * 2 : 0;

        public byte[] ToByteArray() => IsUnicode ? Encoding.Unicode.GetBytes(Value) : Encoding.ASCII.GetBytes(Value);

        public string Value = string.Empty;

        public bool IsUnicode;

        public override string ToString()
        {
            return Value;
        }

        public ITransferible Move(Transfer transfer)
        {
            return transfer.Move(this);
        }
    }

    public static class FStringExt
    {
        public static void Write(this BinaryWriter writer, FString item)
        {
            int length = item?.Length ?? 0;
            if (length > 0)
            {
                if (item.IsUnicode)
                {
                    length = -1 * length / 2;
                    writer.Write(length);
                    byte[] bytes = item.ToByteArray();
                    writer.Write(bytes);
                }
                else
                {
                    writer.Write(length);
                    writer.Write(item.ToByteArray());
                    writer.Write((byte)0);
                }
            }
            else
            {
                writer.Write(0);
            }
        }

        public static FString Read(this BinaryReader reader, ref FString item)
        {
            int size = reader.ReadInt32();
            if (size > 1024 * 1024) throw new InvalidOperationException("FString to big");
            bool bLoadUnicodeChar = size < 0;
            if (bLoadUnicodeChar)
                size = -2 * size;
            if (size > 0)
            {
                item ??= new();
                if (bLoadUnicodeChar)
                {
                    item.IsUnicode = true;
                    byte[] bytes = new byte[size];
                    reader.Read(bytes, 0, size);
                    string text = Encoding.Unicode.GetString(bytes);
                    item.Value = text;
                }
                else
                {
                    byte[] bytes = new byte[size - 1];
                    reader.Read(bytes, 0, size - 1);
                    string text = Encoding.ASCII.GetString(bytes);
                    _ = reader.ReadByte();
                    item.Value = text;
                    if (text.IndexOf('\0') != -1) throw new InvalidOperationException("Invalid FString");
                }
            }
            return item;
        }

        public static FString ReadFString(this BinaryReader reader)
        {
            var item = new FString();
            return reader.Read(ref item);
        }
    }

    public class FStringJsonConverter : JsonConverter<FString>
    {
        public override FString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string text = reader.GetString()!;
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            bool isUnicode = false;
            if (bytes.Length > 0 && bytes[0] is 0x02 or 0x03)
            {
                isUnicode = true;
            }
            if (bytes.Length > 2 && bytes[bytes.Length - 1] == 0 && bytes[bytes.Length - 2] == 0)
            {
                isUnicode = true;
            }
            return new FString(text, isUnicode);
        }

        public override FString ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }

        public override void Write(Utf8JsonWriter writer, FString value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Value);
        }

        public override void WriteAsPropertyName(Utf8JsonWriter writer, FString value, JsonSerializerOptions options)
        {
            string text = value.ToString();
            writer.WritePropertyName(text);
        }
    }
}
