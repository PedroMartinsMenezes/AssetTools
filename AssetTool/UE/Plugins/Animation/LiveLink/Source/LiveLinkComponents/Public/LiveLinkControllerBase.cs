namespace AssetTool
{
    [JsonAsset("LiveLinkControllerBase")]
    public class ULiveLinkControllerBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}