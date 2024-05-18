namespace AssetTool
{
    [Location("class COREUOBJECT_API FUInt16Property : public TProperty_Numeric<uint16>")]
    public class FUInt16Property : FNumericProperty
    {
        public const string TYPE_NAME = "UInt16Property";
        public override string TypeName => TYPE_NAME;

        public new FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        public UInt16 MoveValue(Transfer transfer, UInt16 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
