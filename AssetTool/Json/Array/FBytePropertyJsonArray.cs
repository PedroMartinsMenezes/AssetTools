using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("byte[]")]
    public class FBytePropertyJsonArray : BasePropertyJsonArray<TUInt8>
    {
        public FBytePropertyJsonArray() { }
        public FBytePropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "byte[]";
        public override int Size => 1;
        public override string InnerTypeName => FByteProperty.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TUInt8 { Value = uint8.Parse(str, CultureInfo.InvariantCulture) };
    }
}
