using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("long[]")]
    public class FInt64PropertyJsonArray : BasePropertyJsonArray<Int64>
    {
        public FInt64PropertyJsonArray() { }
        public FInt64PropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "long[]";
        public override int Size => 8;
        public override string InnerTypeName => FInt64Property.TYPE_NAME;
    }
}
