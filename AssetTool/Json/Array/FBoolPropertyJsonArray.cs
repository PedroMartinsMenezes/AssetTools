using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("bool[]")]
    public class FBoolPropertyJsonArray : BasePropertyJsonArray<TUInt8>
    {
        public FBoolPropertyJsonArray() { }
        public FBoolPropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "bool[]";
        public override int Size => 1;
        public override string InnerTypeName => FBoolProperty.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TUInt8 { Value = uint8.Parse(str, CultureInfo.InvariantCulture) };
    }
}
