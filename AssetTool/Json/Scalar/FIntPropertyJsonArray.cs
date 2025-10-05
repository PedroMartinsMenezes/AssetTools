using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("int[]")]
    public class FIntPropertyJsonArray : BasePropertyJsonArray<TInt32>
    {
        public FIntPropertyJsonArray() { }
        public FIntPropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "int[]";
        public override int Size => 4;
        public override string InnerTypeName => FIntProperty.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TInt32 { Value = Int32.Parse(str, CultureInfo.InvariantCulture) };
    }
}
