namespace AssetTool
{
    [Location("class COREUOBJECT_API FUInt32Property : public TProperty_Numeric<uint32>")]
    public class FUInt32Property : FNumericProperty
    {
        public const string TYPE_NAME = "UInt32Property";
        public override string TypeName => TYPE_NAME;

        public new FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        public UInt32 MoveValue(Transfer transfer, UInt32 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
