using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("ulong[]")]
    public class FUInt64PropertyJsonArray : BasePropertyJsonArray<TInt64>
    {
        public FUInt64PropertyJsonArray() { }

        public override string Name => "ulong[]";
        public override int Size => 8;
        public override string InnerTypeName => FUInt64Property.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TUInt64 { Value = UInt64.Parse(str, CultureInfo.InvariantCulture) };
    }
}
