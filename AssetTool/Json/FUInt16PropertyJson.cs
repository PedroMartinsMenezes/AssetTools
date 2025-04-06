using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("ushort")]
    public class FUInt16PropertyJson : BasePropertyJson<UInt16>
    {
        public FUInt16PropertyJson() { }
        public FUInt16PropertyJson(FPropertyTag tag) : base(tag) { }

        public override string Name => "ushort";
        public override int Size => 2;
        public override string TypeName => FUInt16Property.TYPE_NAME;
    }
}
