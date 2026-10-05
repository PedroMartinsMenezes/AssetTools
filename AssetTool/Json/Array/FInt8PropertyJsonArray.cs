using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("sbyte[]")]
    public class FInt8PropertyJsonArray : BasePropertyJsonArray
    {
        public FInt8PropertyJsonArray() { }

        public override string Name => "sbyte[]";
        public override int Size => 1;
        public override string InnerTypeName => FInt8Property.TYPE_NAME;

        public override object StringToItem(string str) => new TInt8 { Value = sbyte.Parse(str, CultureInfo.InvariantCulture) };
    }
}
