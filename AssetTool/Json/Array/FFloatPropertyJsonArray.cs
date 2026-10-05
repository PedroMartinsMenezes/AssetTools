using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("float[]")]
    public class FFloatPropertyJsonArray : BasePropertyJsonArray
    {
        public FFloatPropertyJsonArray() { }

        public override string Name => "float[]";
        public override int Size => 4;
        public override string InnerTypeName => FFloatProperty.TYPE_NAME;

        public override object StringToItem(string str) => new TFloat { Value = float.Parse(str, CultureInfo.InvariantCulture) };
    }
}
