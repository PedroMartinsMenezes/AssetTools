using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("double")]
    public class FDoublePropertyJson : BasePropertyJson
    {
        public FDoublePropertyJson() { }

        public override string Name => "double";
        public override int Size => 8;
        public override string TypeName => FDoubleProperty.TYPE_NAME;
    }
}
