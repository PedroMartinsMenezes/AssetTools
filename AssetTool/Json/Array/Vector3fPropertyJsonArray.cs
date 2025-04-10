using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("vector3f[]")]
    public class Vector3fPropertyJsonArray : BasePropertyJsonArray<FVector3f>
    {
        public Vector3fPropertyJsonArray() { }
        public Vector3fPropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "vector3f[]";
        public override int Size => 12;
        public override string InnerTypeName => FStructProperty.TYPE_NAME;
        public override string StructName => FVector3f.StructName;
        public override string ItemToString(object item) => ((FVector3f)item).GetString();
        public override object StringToItem<T2>(string str) => FVector3f.FromString(str);
    }
}
