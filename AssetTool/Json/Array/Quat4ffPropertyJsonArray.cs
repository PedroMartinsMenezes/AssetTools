using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("quat4f[]")]
    public class Quat4fPropertyJsonArray : BasePropertyJsonArray<FQuat4f>
    {
        public Quat4fPropertyJsonArray() { }
        public Quat4fPropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "quat4f[]";
        public override int Size => 16;
        public override string InnerTypeName => FStructProperty.TYPE_NAME;
        public override string StructName => FQuat4f.StructName;
        public override string ItemToString(object item) => ((FQuat4f)item).GetString();
        public override object StringToItem<T2>(string str) => FQuat4f.FromString(str);
    }
}
