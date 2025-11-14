using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value.Length > 0 ? Value : \"None\"}")]
    public class FString : ITransferable
    {
        public int SizeOf() => 4 + Length;

        public FString() { }

        public FString(string value, bool isUnicode = false)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(value ?? string.Empty);
            isUnicode = false;
            if (bytes.Length > 0 && bytes[0] is 0x02 or 0x03)
            {
                if (bytes.Length > 2 && bytes[bytes.Length - 1] == 0 && bytes[bytes.Length - 2] == 0)
                {
                    isUnicode = true;
                }
                else
                {
                    byte[] bytes2 = new byte[bytes.Length / 2];
                    for (int i = 0; i < bytes2.Length; i++)
                    {
                        bytes2[i] = bytes[2 * i];
                    }
                    value = Encoding.ASCII.GetString(bytes2);
                }
            }
            else if (bytes.Length > 2 && bytes[bytes.Length - 1] == 0 && bytes[bytes.Length - 2] == 0)
            {
                isUnicode = true;
            }
            else if (Array.Exists(bytes, x => x > 127))
            {
                isUnicode = true;
            }
            Value = value ?? string.Empty;
            IsUnicode = isUnicode;
        }

        [JsonIgnore] public int Length => IsUnicode ? UnicodeLength : AnsiLength;
        [JsonIgnore] public int AnsiLength => Value.Length > 0 ? Value.Length + 1 : 0;
        [JsonIgnore] public int UnicodeLength => Value.Length > 0 ? Value.Length * 2 : 0;

        public int TagSize(Transfer transfer) => IsUnicode ? UnicodeLength + 4 : AnsiLength + 4;

        public byte[] ToByteArray() => IsUnicode ? Encoding.Unicode.GetBytes(Value) : Encoding.ASCII.GetBytes(Value);

        public string Value = string.Empty;

        public bool IsUnicode;

        public override string ToString()
        {
            return Value;
        }

        public ITransferable Move(Transfer transfer)
        {
            return transfer.Move(this);
        }
    }

    public class FStringJsonConverter : JsonConverter<FString>
    {
        public override FString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FString(reader.GetString()!);
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
            writer.WritePropertyName(value.ToString());
        }
    }
}
