namespace AssetTool
{
    [JsonAsset("LiveLinkTransformController")]
    public class ULiveLinkTransformController : ULiveLinkControllerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}