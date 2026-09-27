using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("name[]")]
    public class FNamePropertyJsonArray : BasePropertyJsonArray<FName>
    {
        public FNamePropertyJsonArray() { }

        public override string Name => "name[]";
        public override int Size => 8;
        public override string InnerTypeName => FNameProperty.TYPE_NAME;
        public override string Separator => " • ";

        public override object StringToItem<T2>(string str) => new FName(str);
    }
}
