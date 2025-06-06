namespace AssetTool
{
    [JsonAsset("ContentBrowserConfig")]
    public class UContentBrowserConfig : UEditorConfigBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBrowserCollectionProjectSettings")]
    public class UContentBrowserCollectionProjectSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}