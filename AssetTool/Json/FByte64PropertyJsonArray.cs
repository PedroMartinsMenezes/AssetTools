using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("byte64[]")]
    public class FByte64PropertyJsonArray : BasePropertyJsonArray<UInt64>
    {
        public FByte64PropertyJsonArray() { }
        public FByte64PropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "byte64[]";
        public override int Size => 8;
        public override string InnerTypeName => FByteProperty.TYPE_NAME;
    }
}
