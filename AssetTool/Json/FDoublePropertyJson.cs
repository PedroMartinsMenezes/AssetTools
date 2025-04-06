using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("double")]
    public class FDoublePropertyJson : BasePropertyJson<double>
    {
        public FDoublePropertyJson() { }
        public FDoublePropertyJson(FPropertyTag tag) : base(tag) { }

        public override string Name => "double";
        public override int Size => 8;
        public override string TypeName => FDoubleProperty.TYPE_NAME;
    }
}
