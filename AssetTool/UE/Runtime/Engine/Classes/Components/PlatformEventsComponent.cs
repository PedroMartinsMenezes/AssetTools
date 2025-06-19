namespace AssetTool
{
    [JsonAsset("PlatformEventsComponent")]
    public class UPlatformEventsComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}