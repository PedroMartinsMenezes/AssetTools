using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("ushort[]")]
    public class FUInt16PropertyJsonArray : BasePropertyJsonArray<TUInt16>
    {
        public FUInt16PropertyJsonArray() { }

        public override string Name => "ushort[]";
        public override int Size => 2;
        public override string InnerTypeName => FUInt16Property.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TUInt16 { Value = ushort.Parse(str, CultureInfo.InvariantCulture) };
    }
}
