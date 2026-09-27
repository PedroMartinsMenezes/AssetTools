using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("byte[]")]
    public class FBytePropertyJsonArray : BasePropertyJsonArray
    {
        public FBytePropertyJsonArray() { }

        public override string Name => "byte[]";
        public override int Size => 1;
        public override string InnerTypeName => FByteProperty.TYPE_NAME;

        public override object StringToItem(string str) => new TUInt8 { Value = uint8.Parse(str, CultureInfo.InvariantCulture) };
    }
}
