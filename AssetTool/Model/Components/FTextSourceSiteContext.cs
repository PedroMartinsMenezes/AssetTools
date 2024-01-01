namespace AssetTool
{
    public class FTextSourceSiteContext
    {
        public FString KeyName = new();
        public FString SiteDescription = new();
        public FBool IsEditorOnly;
        public FBool IsOptional;
        public FLocMetadataObject InfoMetaData = new();
        public FLocMetadataObject KeyMetaData = new();
    }
}
