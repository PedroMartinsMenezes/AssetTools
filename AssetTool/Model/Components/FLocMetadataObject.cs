namespace AssetTool
{
    public class FLocMetadataObject : ITransferible
    {
        public List<FString> MapKeys;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FLocMetadataObject& Object)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref MapKeys);
            return this;
        }
    }
}
