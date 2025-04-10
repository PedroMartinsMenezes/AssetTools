using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("short")]
    public class FInt16PropertyJson : BasePropertyJson<Int16>
    {
        public FInt16PropertyJson() { }

        public override string Name => "short";
        public override int Size => 2;
        public override string TypeName => FInt16Property.TYPE_NAME;
    }
}
