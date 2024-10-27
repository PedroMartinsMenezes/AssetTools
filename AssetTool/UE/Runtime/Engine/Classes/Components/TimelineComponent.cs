namespace AssetTool
{
    [JsonAsset("TimelineComponent")]
    public class UTimelineComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}