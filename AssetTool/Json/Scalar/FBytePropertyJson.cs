using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("byte")]
    public class FBytePropertyJson : BasePropertyJson
    {
        public FBytePropertyJson() { }

        public override string Name => "byte";
        public override int Size => 1;
        public override string TypeName => FByteProperty.TYPE_NAME;
    }
}
