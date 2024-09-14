namespace AssetTool
{
    [Location("void FEnumProperty::Serialize( FArchive& Ar )")]
    public class FEnumProperty : FProperty
    {
        public const string TYPE_NAME = "EnumProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;
        public FName PropertyTypeName;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            SerializeSingleField(transfer);
            return this; //@@@ 367602
        }

        private void SerializeSingleField(Transfer transfer)
        {
            transfer.Move(ref PropertyTypeName);
        }
    }
}
