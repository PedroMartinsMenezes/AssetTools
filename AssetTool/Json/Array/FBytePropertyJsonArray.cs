using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("byte[]")]
    public class FBytePropertyJsonArray : BasePropertyJsonArray<byte>
    {
        public FBytePropertyJsonArray() { }
        public FBytePropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "byte[]";
        public override int Size => 1;
        public override string InnerTypeName => FByteProperty.TYPE_NAME;
    }
}
