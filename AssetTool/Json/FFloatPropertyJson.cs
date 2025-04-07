using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("float")]
    public class FFloatPropertyJson : BasePropertyJson<float>
    {
        public FFloatPropertyJson() { }

        public override string Name => "float";
        public override int Size => 4;
        public override string TypeName => FFloatProperty.TYPE_NAME;
    }
}
