namespace AssetTool
{
    [JsonAsset("TimelineComponent")]
    public class UTimelineComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}