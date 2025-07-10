namespace AssetTool
{
    public class FObjectPtr : ITransferible
    {
        public FPackageIndex Index;

        [Location("FArchive& FLinkerLoad::operator<<(FObjectPtr& ObjectPtr)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            return this;
        }
    }
}
