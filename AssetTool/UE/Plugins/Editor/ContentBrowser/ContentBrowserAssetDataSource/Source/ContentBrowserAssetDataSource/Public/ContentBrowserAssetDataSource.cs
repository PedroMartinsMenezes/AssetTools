namespace AssetTool
{
    [JsonAsset("ContentBrowserAssetDataSource")]
    public class UContentBrowserAssetDataSource : UContentBrowserDataSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}