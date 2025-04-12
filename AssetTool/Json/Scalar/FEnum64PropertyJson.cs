using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("enum64")]
    public class FEnum64PropertyJson : BasePropertyJson
    {
        public FEnum64PropertyJson() { }

        public override string Name => "enum64";
        public override int Size => 8;
        public override string TypeName => FEnumProperty.TYPE_NAME;
    }
}
