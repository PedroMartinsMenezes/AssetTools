using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("int[]")]
    public class FIntPropertyJsonArray : BasePropertyJsonArray<Int32>
    {
        public FIntPropertyJsonArray() { }
        public FIntPropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "int[]";
        public override int Size => 4;
        public override string InnerTypeName => FIntProperty.TYPE_NAME;
    }
}
