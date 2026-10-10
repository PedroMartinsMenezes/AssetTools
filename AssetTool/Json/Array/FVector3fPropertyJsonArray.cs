using System.Diagnostics;
using System.Globalization;
using System.Text;

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
        public override void AppendItem(StringBuilder builder, object item)
        {
            FVector3f v = (FVector3f)item;
            builder.Append(CultureInfo.InvariantCulture, $"{v.X},{v.Y},{v.Z}");
        }
        public override object SpanToItem(ReadOnlySpan<char> str) => FVector3f.FromString(str);
    }
}
