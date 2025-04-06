using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("enum64")]
    public class FEnum64PropertyJson : BasePropertyJson<UInt64>
    {
        public FEnum64PropertyJson() { }
        public FEnum64PropertyJson(FPropertyTag tag) : base(tag) { }

        public override string Name => "enum64";
        public override int Size => 8;
        public override string TypeName => FEnumProperty.TYPE_NAME;
    }
}
