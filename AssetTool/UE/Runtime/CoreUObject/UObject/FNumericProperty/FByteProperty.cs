namespace AssetTool
{
    [Location("class COREUOBJECT_API FByteProperty : public TProperty_Numeric<uint8>")]
    public class FByteProperty : FNumericProperty
    {
        public const string TYPE_NAME = "ByteProperty";
        public override string TypeName => TYPE_NAME;

        public new FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        public byte MoveValue(Transfer transfer, byte value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
