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
        public override string Separator => " • ";

        public override object StringToItem<T2>(string str) => new FString(str);

        public override string WriteExtraFields(FPropertyTag tag)
        {
            string size = $"Size({tag.Size}) ";
            return size;
        }

        public override void ReadExtraFields(FPropertyTag tag, string key)
        {
            tag.Size = key.GetNonNull("Size({0})", x => int.Parse(x));
            if (tag.Size == 8)
            {
                tag.Value = new List<object> { new FString("") };
            }
        }
    }
}
