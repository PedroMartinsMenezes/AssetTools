namespace AssetTool
{
    public class FRigVMNodeLayout : ITransferable
    {
        public List<FRigVMPinCategory> Categories;
        public Dictionary<FString, TInt32> PinIndexInCategory;
        public Dictionary<FString, FString> DisplayNames;

        [Location("FArchive& operator<<(FArchive& Ar, FRigVMNodeLayout& Layout)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Categories);
            if (transfer.Supports.FunctionHeaderLayoutStoresPinIndexInCategory)
            {
                if (transfer.Supports.FunctionHeaderLayoutStoresPinIndexInCategory)
                {
                    transfer.Move(ref PinIndexInCategory);
                }
            }
            transfer.Move(ref DisplayNames);
            return this;
        }
    }

    public class FRigVMPinCategory : ITransferable
    {
        public FString Path;
        public List<FString> Elements;
        public bool bExpandedByDefault;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMPinCategory& Category)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Path);
            transfer.Move(ref Elements);
            if (transfer.Supports.FunctionHeaderLayoutStoresCategoryExpansion)
            {
                transfer.Move(ref bExpandedByDefault);
            }
            return this;
        }
    }
}
