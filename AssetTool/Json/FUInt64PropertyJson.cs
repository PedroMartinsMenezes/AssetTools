using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("ulong")]
    public class FUInt64PropertyJson : BasePropertyJson<UInt64>
    {
        public FUInt64PropertyJson() { }
        public FUInt64PropertyJson(FPropertyTag tag) : base(tag) { }

        public override string Name => "ulong";
        public override int Size => 8;
        public override string TypeName => FUInt64Property.TYPE_NAME;
    }
}
