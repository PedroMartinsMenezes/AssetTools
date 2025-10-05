using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("double[]")]
    public class FDoublePropertyJsonArray : BasePropertyJsonArray<TDouble>
    {
        public FDoublePropertyJsonArray() { }
        public FDoublePropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "double[]";
        public override int Size => 8;
        public override string InnerTypeName => FDoubleProperty.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TDouble { Value = double.Parse(str, CultureInfo.InvariantCulture) };
    }
}
