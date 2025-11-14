namespace AssetTool
{
    [JsonAsset("LiveLinkTransformController")]
    public class ULiveLinkTransformController : ULiveLinkControllerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}