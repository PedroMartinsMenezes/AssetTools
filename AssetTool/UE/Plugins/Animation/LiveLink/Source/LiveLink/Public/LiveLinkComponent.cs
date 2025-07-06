namespace AssetTool
{
    [JsonAsset("LiveLinkComponent")]
    public class ULiveLinkComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}