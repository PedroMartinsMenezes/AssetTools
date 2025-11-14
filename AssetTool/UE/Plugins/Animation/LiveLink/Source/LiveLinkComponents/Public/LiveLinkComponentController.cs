namespace AssetTool
{
    [JsonAsset("LiveLinkComponentController")]
    public class ULiveLinkComponentController : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}