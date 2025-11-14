namespace AssetTool
{
    [JsonAsset("ContentBrowserSettings")]
    public class UContentBrowserSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}