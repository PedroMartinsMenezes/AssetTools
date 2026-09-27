using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("text[]")]
    public class FTextPropertyJsonArray : BasePropertyJsonArray<FString>
    {
        public FTextPropertyJsonArray() { }

        public override string Name => "text[]";
        public override int Size => 0;
        public override string InnerTypeName => FTextProperty.TYPE_NAME;

        public override string WriteExtraFields(FPropertyTag tag)
        {
            return $"Size({tag.Size}) ";
        }

        public override void ReadExtraFields(FPropertyTag tag, string key)
        {
            tag.Size = key.GetNonNull("Size({0})", x => int.Parse(x));
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
