namespace AssetTool
{
    [JsonAsset("ContentBrowserConfig")]
    public class UContentBrowserConfig : UEditorConfigBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBrowserCollectionProjectSettings")]
    public class UContentBrowserCollectionProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}