using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("string[]")]
    public class FStrPropertyJsonArray : BasePropertyJsonArray<FString>
    {
        public FStrPropertyJsonArray() { }

        public override string Name => "string[]";
        public override int Size => 0;
        public override string InnerTypeName => FStrProperty.TYPE_NAME;

        public override string WriteExtraFields(FPropertyTag tag)
        {
            return $"Size({tag.Size}) ";
        }

        public override void ReadExtraFields(FPropertyTag tag, string key)
        {
            tag.Size = key.GetNonNull("Size({0})", x => int.Parse(x));
            if (tag.Size == 8)
            {
                tag.Value = new List<object> { new FString("") };
            }
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
