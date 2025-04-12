using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("byte64")]
    public class FByte64PropertyJson : BasePropertyJson
    {
        public FByte64PropertyJson() { }

        public override string Name => "byte64";
        public override int Size => 8;
        public override string TypeName => FByteProperty.TYPE_NAME;
    }
}
