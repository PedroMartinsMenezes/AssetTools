namespace AssetTool
{
    public class FObjectPtr : ITransferible
    {
        public FPackageIndex Index = new();
        public UInt32 Ptr;

        [Location("FArchive& FLinkerLoad::operator<<(FObjectPtr& ObjectPtr)")]
        public ITransferible Move(Transfer transfer)
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
