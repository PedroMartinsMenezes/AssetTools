namespace AssetTool
{
    [JsonAsset("ContentBrowserFileDataSource")]
    public class UContentBrowserFileDataSource : UContentBrowserDataSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}