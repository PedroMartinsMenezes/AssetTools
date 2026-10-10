using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace AssetTool
{
    [DebuggerDisplay("quat4f[]")]
    public class FQuat4fPropertyJsonArray : BasePropertyJsonArray
    {
        public FQuat4fPropertyJsonArray() { }

        public override string Name => "quat4f[]";
        public override int Size => 16;
        public override string InnerTypeName => FStructProperty.TYPE_NAME;
        public override string StructName => FQuat4f.StructName;
        public override string ItemToString(object item) => ((FQuat4f)item).GetString();
        public override object StringToItem(string str) => FQuat4f.FromString(str);
        public override void AppendItem(StringBuilder builder, object item)
        {
            FQuat4f v = (FQuat4f)item;
            builder.Append(CultureInfo.InvariantCulture, $"{v.X},{v.Y},{v.Z},{v.W}");
        }
        public override object SpanToItem(ReadOnlySpan<char> str) => FQuat4f.FromString(str);
    }
}
