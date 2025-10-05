using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("long[]")]
    public class FInt64PropertyJsonArray : BasePropertyJsonArray<TInt64>
    {
        public FInt64PropertyJsonArray() { }
        public FInt64PropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "long[]";
        public override int Size => 8;
        public override string InnerTypeName => FInt64Property.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TInt64 { Value = Int64.Parse(str, CultureInfo.InvariantCulture) };
    }
}
