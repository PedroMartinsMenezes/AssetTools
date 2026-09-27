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

        public override object FromNativeValue(FPropertyTag tag)
        {
            return tag.Value;
        }

        public override List<object> ToNativeValue(object val)
        {
            return val.ToObject<List<object>>();
        }
    }
}
