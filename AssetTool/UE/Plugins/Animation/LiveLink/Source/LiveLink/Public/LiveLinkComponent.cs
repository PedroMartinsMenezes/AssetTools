namespace AssetTool
{
    [JsonAsset("LiveLinkComponent")]
    public class ULiveLinkComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}