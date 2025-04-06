using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("obj")]
    public class FObjectPropertyJson : BasePropertyJson<UInt32>
    {
        public FObjectPropertyJson() { }
        public FObjectPropertyJson(FPropertyTag tag) : base(tag) { }

        public override string Name => "obj";
        public override int Size => 4;
        public override string TypeName => FObjectProperty.TYPE_NAME;
    }
}
