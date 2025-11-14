namespace AssetTool
{
    [JsonAsset("PlatformEventsComponent")]
    public class UPlatformEventsComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}