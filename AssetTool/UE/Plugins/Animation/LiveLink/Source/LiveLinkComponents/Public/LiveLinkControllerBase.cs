namespace AssetTool
{
    [JsonAsset("LiveLinkControllerBase")]
    public class ULiveLinkControllerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}