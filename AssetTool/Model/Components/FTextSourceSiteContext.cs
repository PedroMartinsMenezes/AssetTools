namespace AssetTool
{
    public class FTextSourceSiteContext
    {
        public FString KeyName = new();
        public FString SiteDescription = new();
        public FBool IsEditorOnly = new();
        public FBool IsOptional = new();
        public FLocMetadataObject InfoMetaData = new();
        public FLocMetadataObject KeyMetaData = new();
    }
}
