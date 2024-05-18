namespace AssetTool
{
    [Location("class COREUOBJECT_API FUInt64Property : public TProperty_Numeric<uint64>")]
    public class FUInt64Property : FNumericProperty
    {
        public const string TYPE_NAME = "UInt64Property";
        public override string TypeName => TYPE_NAME;

        public new FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        public UInt64 MoveValue(Transfer transfer, UInt64 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
