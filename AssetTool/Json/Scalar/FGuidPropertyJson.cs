using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("guid")]
    public class FGuidPropertyJson : BasePropertyJson<FName>
    {
        public FGuidPropertyJson() { }

        public override string Name => "guid";
        public override int Size => 16;
        public override string TypeName => FStructProperty.TYPE_NAME;
        public override string StructName => Consts.Guid;
        public override object DerivedValue(object value) => ((FGuid)value).Value;
        public override object BaseValue(Transfer transfer, object value) => new FGuid((Guid)value);
    }
}
