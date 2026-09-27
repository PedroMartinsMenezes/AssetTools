using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    [DebuggerDisplay("bool[]")]
    public class FBoolPropertyJsonArray : BasePropertyJsonArray
    {
        public FBoolPropertyJsonArray() { }

        public override string Name => "bool[]";
        public override int Size => 1;
        public override string InnerTypeName => FBoolProperty.TYPE_NAME;

        public override object StringToItem(string str) => new TUInt8 { Value = uint8.Parse(str, CultureInfo.InvariantCulture) };
    }
}
