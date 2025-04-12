using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("ulong")]
    public class FUInt64PropertyJson : BasePropertyJson
    {
        public FUInt64PropertyJson() { }

        public override string Name => "ulong";
        public override int Size => 8;
        public override string TypeName => FUInt64Property.TYPE_NAME;
    }
}
