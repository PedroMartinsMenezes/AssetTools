namespace AssetTool
{
    [JsonAsset("ContentBrowserFileDataSource")]
    public class UContentBrowserFileDataSource : UContentBrowserDataSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}