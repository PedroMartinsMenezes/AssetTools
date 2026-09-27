using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("short[]")]
    public class FInt16PropertyJsonArray : BasePropertyJsonArray<TInt16>
    {
        public FInt16PropertyJsonArray() { }

        public override string Name => "short[]";
        public override int Size => 2;
        public override string InnerTypeName => FInt16Property.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TInt16 { Value = short.Parse(str, CultureInfo.InvariantCulture) };
    }
}
