using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("uint[]")]
    public class FUInt32PropertyJsonArray : BasePropertyJsonArray<TInt32>
    {
        public FUInt32PropertyJsonArray() { }

        public override string Name => "uint[]";
        public override int Size => 4;
        public override string InnerTypeName => FUInt32Property.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TUInt32 { Value = UInt32.Parse(str, CultureInfo.InvariantCulture) };
    }
}
