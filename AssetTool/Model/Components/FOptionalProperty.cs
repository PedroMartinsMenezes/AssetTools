namespace AssetTool
{
    [Location("void FOptionalProperty::Serialize(FArchive& Ar)")]
    public class FOptionalProperty : FProperty
    {
        public FName PropertyTypeName;

        public new FOptionalProperty Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyTypeName);
            return this;
        }
    }
}
