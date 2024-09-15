namespace AssetTool
{
    [Location("void FArrayProperty::Serialize( FArchive& Ar )")]
    public class FArrayProperty : FProperty
    {
        public new const string TYPE_NAME = "ArrayProperty";
        public override string TypeName => TYPE_NAME;

        public FName PropertyTypeName;
        public FField SingleField;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            SerializeSingleField(transfer);
            return this;
        }

        private void SerializeSingleField(Transfer transfer)
        {
            transfer.Move(ref PropertyTypeName);
            if (PropertyTypeName.IsFilled)
            {
                SingleField = SingleField ?? UStruct.GetNameToFieldClassMap(transfer, PropertyTypeName);
                SingleField.Move(transfer);
            }
        }
    }
}
