namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FTextSourceSiteContext& This)")]
    public class FTextSourceSiteContext
    {
        public FString KeyName;
        public FString SiteDescription;
        public FBool IsEditorOnly;
        public FBool IsOptional;
        public FLocMetadataObject InfoMetaData = new();
        public FLocMetadataObject KeyMetaData = new();
    }
}
