namespace AssetTool
{
    public class FLocMetadataObject : ITransferible
    {
        public List<FString> MapKeys = [];

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FLocMetadataObject& Object)")]
        public ITransferible Move(Transfer transfer)
        {
            MapKeys.Resize(transfer);
            MapKeys.ForEach(x => transfer.Move(x));
            return this;
        }
    }
}
