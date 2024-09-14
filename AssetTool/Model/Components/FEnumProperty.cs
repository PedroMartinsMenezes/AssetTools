namespace AssetTool
{
    [Location("void FEnumProperty::Serialize( FArchive& Ar )")]
    public class FEnumProperty : FProperty
    {
        public new const string TYPE_NAME = "EnumProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;
        public FName PropertyTypeName;
        public FField SingleField;

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
            if (PropertyTypeName.IsFilled)
            {
                SingleField = (SingleField ?? UStruct.GetNameToFieldClassMap(transfer, PropertyTypeName)).Move(transfer);
            }
        }
    }
}
