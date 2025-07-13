namespace AssetTool
{
    [JsonAsset("LiveLinkLensController")]
    public class ULiveLinkLensController : ULiveLinkControllerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}