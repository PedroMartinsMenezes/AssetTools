using System.Text;
using System.Text.Json.Serialization;

namespace AssetTool.Model.Basic
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
}
