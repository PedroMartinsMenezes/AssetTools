using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("vector3f[]")]
    public class FVector3fPropertyJsonArray : BasePropertyJsonArray
    {
        public FVector3fPropertyJsonArray() { }

        public override string Name => "vector3f[]";
        public override int Size => 12;
        public override string InnerTypeName => FStructProperty.TYPE_NAME;
        public override string StructName => FVector3f.StructName;
        public override string ItemToString(object item) => ((FVector3f)item).GetString();
        public override object StringToItem(string str) => FVector3f.FromString(str);
    }
}
