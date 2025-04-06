using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("bool")]
    public class FBoolPropertyJson : BasePropertyJson<bool>
    {
        public FBoolPropertyJson() { }
        public FBoolPropertyJson(FPropertyTag tag) : base(tag) { }

        public override string Name => "bool";
        public override int Size => 0;
        public override string TypeName => FBoolProperty.TYPE_NAME;
    }
}
