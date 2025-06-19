namespace AssetTool
{
    [JsonAsset("ContentBrowserSettings")]
    public class UContentBrowserSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}