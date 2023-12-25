using System.ComponentModel;
using System.Text;

namespace AssetTool.Model
{
    public class FNameEntrySerialized
    {
        [Description("New")] public int NameSize => Name.Length > 0 ? Name.Length + 1 : 0;

        public string Name = string.Empty;

        public byte[] AnsiName => Encoding.ASCII.GetBytes(Name).Concat(new byte[2048 - Name.Length]).ToArray();

        public byte[] WideName => Encoding.Unicode.GetBytes(Name).Concat(new byte[2048 - Name.Length * 2]).ToArray();
    }
}
