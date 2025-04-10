using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("name")]
    public class FNamePropertyJson : BasePropertyJson<FName>
    {
        public FNamePropertyJson() { }

        public override string Name => "name";
        public override int Size => 8;
        public override string TypeName => FNameProperty.TYPE_NAME;
        public override object DerivedValue(object value) => ((FName)value).ToString();
        public override object BaseValue(Transfer transfer, object value) => new FName((string)value, transfer);
    }
}
