using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("int")]
    public class FIntPropertyJson : BasePropertyJson<Int32>
    {
        public FIntPropertyJson() { }
        public FIntPropertyJson(FPropertyTag tag) : base(tag) { }

        public override string Name => "int";
        public override int Size => 4;
        public override string TypeName => FIntProperty.TYPE_NAME;
    }
}
