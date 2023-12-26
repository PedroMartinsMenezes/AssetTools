using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace AssetTool.Model.Basic
{
    public class FString
    {
        string _value = string.Empty;

        public FString() { }

        public FString(string value)
        {
            _value = value;
        }

        public int Length => _value.Length > 0 ? _value.Length + 1 : 0;        

        public static implicit operator FString(string value) => new FString(value);

        public byte[] ToByteArray() => Encoding.ASCII.GetBytes(_value);
    }
}
