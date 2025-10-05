using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("obj[]")]
    public class FObjectPropertyJsonArray : BasePropertyJsonArray<TUInt32>
    {
        public FObjectPropertyJsonArray() { }
        public FObjectPropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "obj[]";
        public override int Size => 4;
        public override string InnerTypeName => FObjectProperty.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TUInt32 { Value = UInt32.Parse(str, CultureInfo.InvariantCulture) };
    }
}
