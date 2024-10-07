namespace AssetTool
{
    public class FByteProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "ByteProperty";
        public override string TypeName => TYPE_NAME;
        public UInt32 Enum;

        [Location("void FByteProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Enum);
            return this;
        }

        [Location("void FByteProperty::SerializeItem( FStructuredArchive::FSlot Slot, void* Value, void const* Defaults ) const")]
        public static byte MoveValue(Transfer transfer, byte value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
