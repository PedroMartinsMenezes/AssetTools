using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("array[]")]
    public class GenericPropertyJsonArray : BasePropertyJsonArray
    {
        public GenericPropertyJsonArray() { }

        public override string Name => "array[]";
        public override int Size => 0;
        public override string InnerTypeName => FStrProperty.TYPE_NAME;

        public override string FromNativeFields(FPropertyTag tag)
        {
            return $"Size({tag.Size}) InnerType({tag.InnerType}) ";
        }

        public override void ToNativeFields(FPropertyTag tag, string key)
        {
            tag.Size = key.GetNonNull("Size({0})", x => int.Parse(x));
            tag.InnerType = key.GetNonNull("InnerType({0})", x => new FName(x));
        }

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
