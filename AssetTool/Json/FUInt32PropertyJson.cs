using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("uint")]
    public class FUInt32PropertyJson : BasePropertyJson<UInt32>
    {
        public FUInt32PropertyJson() { }

        public override string Name => "uint";
        public override int Size => 4;
        public override string TypeName => FUInt32Property.TYPE_NAME;
    }
}
