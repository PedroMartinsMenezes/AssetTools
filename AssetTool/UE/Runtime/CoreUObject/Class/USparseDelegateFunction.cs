namespace AssetTool
{
    [JsonAsset("SparseDelegateFunction")]
    public class USparseDelegateFunction : UStruct
    {
        public FName OwningClassName;
        public FName DelegateName;

        [Location("void USparseDelegateFunction::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref OwningClassName);
            transfer.Move(ref DelegateName);
            return this;
        }
    }
}
