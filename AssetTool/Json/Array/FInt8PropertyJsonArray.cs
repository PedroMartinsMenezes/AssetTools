using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("sbyte[]")]
    public class FInt8PropertyJsonArray : BasePropertyJsonArray<TInt64>
    {
        public FInt8PropertyJsonArray() { }

        public override string Name => "sbyte[]";
        public override int Size => 1;
        public override string InnerTypeName => FInt8Property.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TInt8 { Value = sbyte.Parse(str, CultureInfo.InvariantCulture) };
    }
}
