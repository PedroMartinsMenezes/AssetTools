using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("string")]
    public class FStrPropertyJson : BasePropertyJson<FName>
    {
        public FStrPropertyJson() { }

        public override string Name => "string";
        public override int Size => 0;
        public override int ComputedSize(Transfer transfer, object value) => new FString((string)value).TagSize(transfer);
        public override string TypeName => FStrProperty.TYPE_NAME;
        public override object DerivedValue(object value) => ((FString)value).Value;
        public override object BaseValue(Transfer transfer, object value) => new FString((string)value);
    }
}
