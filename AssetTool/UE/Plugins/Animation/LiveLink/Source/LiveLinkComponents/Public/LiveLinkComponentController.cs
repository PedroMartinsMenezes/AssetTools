namespace AssetTool
{
    [JsonAsset("LiveLinkComponentController")]
    public class ULiveLinkComponentController : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}