namespace AssetTool
{
    public class FOptionalProperty : FProperty
    {
        public new const string TYPE_NAME = "OptionalProperty";
        public override string TypeName => TYPE_NAME;

        public FName PropertyTypeName;
        public FField SingleField;

        public UInt32 Value;
        public byte BoolProperty;

        [Location("void FOptionalProperty::Serialize(FArchive& Ar)")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            FField.SerializeSingleField(transfer, ref PropertyTypeName, ref SingleField);
            return this;
        }

        public FField MoveValue(Transfer transfer, string innerType, int size)
        {
            transfer.Move(ref Value);
            if (size > 4)
            {
                //TODO: Complete this !
                if (innerType == FBoolProperty.TYPE_NAME)
                {
                    transfer.Move(ref BoolProperty);
                }
            }
            return this;
        }
    }
}
