using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("soft")]
    public class SoftObjectPropertyJson : BasePropertyJson<UInt32>
    {
        public SoftObjectPropertyJson() { }

        public override string Name => "soft";
        public override int Size => 4;
        public override string TypeName => FSoftObjectProperty.TYPE_NAME;
    }
}
