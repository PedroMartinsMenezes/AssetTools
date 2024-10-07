namespace AssetTool
{
    public class FTextSourceSiteContext : ITransferible
    {
        public FString KeyName;
        public FString SiteDescription;
        public FBool IsEditorOnly;
        public FBool IsOptional;
        public FLocMetadataObject InfoMetaData;
        public FLocMetadataObject KeyMetaData;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FTextSourceSiteContext& This)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref KeyName);
            transfer.Move(ref SiteDescription);
            transfer.Move(ref IsEditorOnly);
            transfer.Move(ref IsOptional);
            transfer.Move(ref InfoMetaData);
            transfer.Move(ref KeyMetaData);
            return this;
        }
    }
}
