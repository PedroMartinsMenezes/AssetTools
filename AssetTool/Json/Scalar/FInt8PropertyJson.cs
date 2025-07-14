using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("int8")]
    public class FInt8PropertyJson : BasePropertyJson
    {
        public FInt8PropertyJson() { }

        public override string Name => "int8";
        public override int Size => 1;
        public override string TypeName => FInt8Property.TYPE_NAME;
    }
}
