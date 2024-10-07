namespace AssetTool
{
    public class FBoolProperty : FProperty
    {
        public new const string TYPE_NAME = "BoolProperty";
        public override string TypeName => TYPE_NAME;

        public byte FieldSize;
        public byte ByteOffset;
        public byte ByteMask;
        public byte FieldMask;
        public byte BoolSize;
        public byte NativeBool;

        [Location("void FBoolProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref FieldSize);
            transfer.Move(ref ByteOffset);
            transfer.Move(ref ByteMask);
            transfer.Move(ref FieldMask);
            transfer.Move(ref BoolSize);
            transfer.Move(ref NativeBool);
            return this;
        }

        public static byte MoveValue(Transfer transfer, byte value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
