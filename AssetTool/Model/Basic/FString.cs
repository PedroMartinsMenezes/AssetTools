using System.Text;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FString
    {
        public FString() { }

        public FString(string value)
        {
            Value = value;
        }

        public static implicit operator FString(string value) => new FString(value);

        [JsonIgnore]
        public int Length => Value.Length > 0 ? Value.Length + 1 : 0;

        public byte[] ToByteArray() => Encoding.ASCII.GetBytes(Value);

        public string Value = string.Empty;
    }

    public static class FStringExt
    {
        public static void Write(this BinaryWriter writer, FString text)
        {
            writer.Write(text.Length);
            if (text.Length > 0)
            {
                writer.Write(text.ToByteArray());
                writer.Write((byte)0);
            }
        }

        //TODO remover o ref e fazer item.Value = text
        public static FString Read(this BinaryReader reader, FString item)
        {
            int size = reader.ReadInt32();
            if (size > 0)
            {
                byte[] bytes = new byte[size - 1];
                reader.Read(bytes, 0, size - 1);
                string text = Encoding.ASCII.GetString(bytes);
                _ = reader.ReadByte();
                item.Value = text;
            }
            return item;
        }
    }
}
