using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("long[]")]
    public class FInt64PropertyJsonArray : BasePropertyJsonArray
    {
        public FInt64PropertyJsonArray() { }

        public override string Name => "long[]";
        public override int Size => 8;
        public override string InnerTypeName => FInt64Property.TYPE_NAME;

        public override object StringToItem(string str) => new TInt64 { Value = Int64.Parse(str, CultureInfo.InvariantCulture) };
    }
}
