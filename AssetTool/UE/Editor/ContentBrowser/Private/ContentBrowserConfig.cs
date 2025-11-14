namespace AssetTool
{
    [JsonAsset("ContentBrowserConfig")]
    public class UContentBrowserConfig : UEditorConfigBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBrowserCollectionProjectSettings")]
    public class UContentBrowserCollectionProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}