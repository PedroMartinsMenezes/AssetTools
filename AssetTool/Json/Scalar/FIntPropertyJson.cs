using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("int")]
    public class FIntPropertyJson : BasePropertyJson
    {
        public FIntPropertyJson() { }

        public override string Name => "int";
        public override int Size => 4;
        public override string TypeName => FIntProperty.TYPE_NAME;
    }
}
