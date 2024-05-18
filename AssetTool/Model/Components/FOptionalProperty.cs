namespace AssetTool
{
    [Location("void FOptionalProperty::Serialize(FArchive& Ar)")]
    public class FOptionalProperty : FProperty
    {
        public FName PropertyTypeName;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyTypeName);
            return this;
        }
    }
}
