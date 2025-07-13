namespace AssetTool
{
    [JsonAsset("ContentBrowserAssetDataSource")]
    public class UContentBrowserAssetDataSource : UContentBrowserDataSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}