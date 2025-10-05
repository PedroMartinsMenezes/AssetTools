using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("float[]")]
    public class FFloatPropertyJsonArray : BasePropertyJsonArray<TFloat>
    {
        public FFloatPropertyJsonArray() { }
        public FFloatPropertyJsonArray(FPropertyTag tag) : base(tag) { }

        public override string Name => "float[]";
        public override int Size => 4;
        public override string InnerTypeName => FFloatProperty.TYPE_NAME;

        public override object StringToItem<T2>(string str) => new TFloat { Value = float.Parse(str, CultureInfo.InvariantCulture) };
    }
}
