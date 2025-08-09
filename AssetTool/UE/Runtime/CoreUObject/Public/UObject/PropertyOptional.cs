namespace AssetTool
{
    public class FOptionalProperty : FProperty
    {
        public new const string TYPE_NAME = "OptionalProperty";
        public override string TypeName => TYPE_NAME;

        public FName PropertyTypeName;
        public FField SingleField;

        [Location("void FOptionalProperty::Serialize(FArchive& Ar)")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            FField.SerializeSingleField(transfer, ref PropertyTypeName, ref SingleField);
            return this;
        }
    }
}
