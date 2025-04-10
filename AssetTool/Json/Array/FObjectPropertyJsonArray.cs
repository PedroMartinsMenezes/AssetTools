using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("obj[]")]
    public class FObjectPropertyJsonArray : BasePropertyJsonArray<UInt32>
    {
        public FObjectPropertyJsonArray() { }
        public FObjectPropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "obj[]";
        public override int Size => 4;
        public override string InnerTypeName => FObjectProperty.TYPE_NAME;
    }
}
