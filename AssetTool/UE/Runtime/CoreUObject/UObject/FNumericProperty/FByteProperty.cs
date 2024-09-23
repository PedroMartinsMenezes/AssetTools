namespace AssetTool
{
    [Location("class COREUOBJECT_API FByteProperty : public TProperty_Numeric<uint8>")]
    public class FByteProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "ByteProperty";
        public override string TypeName => TYPE_NAME;
        public UInt32 Enum;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Enum);
            return this;
        }

        public static byte MoveValue(Transfer transfer, byte value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
