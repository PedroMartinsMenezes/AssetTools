namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FLocMetadataObject& Object)")]
    public class FLocMetadataObject
    {
        [Sized] public List<FString> MapKeys = [];
    }
}
