using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("byte64[]")]
    public class FByte64PropertyJsonArray : BasePropertyJsonArray<TUInt64>
    {
        public FByte64PropertyJsonArray() { }
        public FByte64PropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "byte64[]";
        public override int Size => 8;
        public override string InnerTypeName => FByteProperty.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TUInt64 { Value = UInt64.Parse(str, CultureInfo.InvariantCulture) };
    }
}
