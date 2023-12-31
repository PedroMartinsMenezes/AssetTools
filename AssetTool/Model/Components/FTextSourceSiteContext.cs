namespace AssetTool
{
    public class FTextSourceSiteContext
    {
        public FString KeyName = new();
        public FString SiteDescription = new();
        public bool IsEditorOnly;
        public bool IsOptional;
        public FLocMetadataObject InfoMetaData = new();
        public FLocMetadataObject KeyMetaData = new();
    }
}
