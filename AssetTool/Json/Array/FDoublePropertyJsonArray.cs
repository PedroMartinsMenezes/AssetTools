using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("double[]")]
    public class FDoublePropertyJsonArray : BasePropertyJsonArray
    {
        public FDoublePropertyJsonArray() { }

        public override string Name => "double[]";
        public override int Size => 8;
        public override string InnerTypeName => FDoubleProperty.TYPE_NAME;

        public override object StringToItem(string str) => new TDouble { Value = double.Parse(str, CultureInfo.InvariantCulture) };
    }
}
