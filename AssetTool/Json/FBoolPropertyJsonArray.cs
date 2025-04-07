using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("bool[]")]
    public class FBoolPropertyJsonArray : BasePropertyJsonArray<byte>
    {
        public FBoolPropertyJsonArray() { }
        public FBoolPropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "bool[]";
        public override int Size => 1;
        public override string InnerTypeName => FBoolProperty.TYPE_NAME;
    }
}
