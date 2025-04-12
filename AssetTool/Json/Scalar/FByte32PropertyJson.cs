using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("byte32")]
    public class FByte32PropertyJson : BasePropertyJson
    {
        public FByte32PropertyJson() { }

        public override string Name => "byte32";
        public override int Size => 4;
        public override string TypeName => FByteProperty.TYPE_NAME;
    }
}
