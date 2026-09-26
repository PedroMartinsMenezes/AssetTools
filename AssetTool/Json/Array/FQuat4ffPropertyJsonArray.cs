using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("quat4f[]")]
    public class FQuat4fPropertyJsonArray : BasePropertyJsonArray<FQuat4f>
    {
        public FQuat4fPropertyJsonArray() { }

        public override string Name => "quat4f[]";
        public override int Size => 16;
        public override string InnerTypeName => FStructProperty.TYPE_NAME;
        public override string StructName => FQuat4f.StructName;
        public override string ItemToString(object item) => ((FQuat4f)item).GetString();
        public override object StringToItem<T2>(string str) => FQuat4f.FromString(str);
    }
}
