using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("double[]")]
    public class FDoublePropertyJsonArray : BasePropertyJsonArray<double>
    {
        public FDoublePropertyJsonArray() { }
        public FDoublePropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "double[]";
        public override int Size => 8;
        public override string InnerTypeName => FDoubleProperty.TYPE_NAME;
        public override string ItemToString(object item) => ((double)item).ToString(CultureInfo.InvariantCulture);
        public override object StringToItem<T2>(string str) => (object)double.Parse(str, CultureInfo.InvariantCulture);
    }
}
