using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("enum32")]
    public class FEnum32PropertyJson : BasePropertyJson<UInt32>
    {
        public FEnum32PropertyJson() { }

        public override string Name => "enum32";
        public override int Size => 4;
        public override string TypeName => FEnumProperty.TYPE_NAME;
    }
}
