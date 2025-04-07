using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("float[]")]
    public class FFloatPropertyJsonArray : BasePropertyJsonArray<float>
    {
        public FFloatPropertyJsonArray() { }
        public FFloatPropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "float[]";
        public override int Size => 4;
        public override string InnerTypeName => FFloatProperty.TYPE_NAME;
    }
}
