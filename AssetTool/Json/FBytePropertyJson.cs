using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("byte")]
    public class FBytePropertyJson : BasePropertyJson<byte>
    {
        public FBytePropertyJson() { }
        public FBytePropertyJson(FPropertyTag tag) : base(tag) { }

        public override string Name => "byte";
        public override int Size => 1;
        public override string TypeName => FByteProperty.TYPE_NAME;
    }
}
