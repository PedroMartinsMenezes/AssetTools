namespace AssetTool
{
    [JsonAsset("SparseDelegateFunction")]
    public class USparseDelegateFunction : UDelegateFunction
    {
        public FName OwningClassName;
        public FName DelegateName;

        [Location("void USparseDelegateFunction::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref OwningClassName);
            transfer.Move(ref DelegateName);
            return this;
        }
    }
}
