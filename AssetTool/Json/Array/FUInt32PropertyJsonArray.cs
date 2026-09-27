using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("uint[]")]
    public class FUInt32PropertyJsonArray : BasePropertyJsonArray
    {
        public FUInt32PropertyJsonArray() { }

        public override string Name => "uint[]";
        public override int Size => 4;
        public override string InnerTypeName => FUInt32Property.TYPE_NAME;

        public override object StringToItem(string str) => new TUInt32 { Value = UInt32.Parse(str, CultureInfo.InvariantCulture) };
    }
}
