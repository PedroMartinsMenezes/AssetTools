namespace AssetTool
{
    public class FObjectPtr
    {
        public FPackageIndex Index = new();
        public UInt32 Ptr;

        [Location("FArchive& FLinkerLoad::operator<<(FObjectPtr& ObjectPtr)")]
        public FObjectPtr Move(Transfer transfer)
        {
            transfer.Move(ref Index.Index);
            if (Index.Index > 0)
            {
                transfer.Move(ref Ptr);
            }
            return this;
        }
    }
}
