using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("long")]
    public class FInt64PropertyJson : BasePropertyJson
    {
        public FInt64PropertyJson() { }

        public override string Name => "long";
        public override int Size => 8;
        public override string TypeName => FInt64Property.TYPE_NAME;
    }
}
