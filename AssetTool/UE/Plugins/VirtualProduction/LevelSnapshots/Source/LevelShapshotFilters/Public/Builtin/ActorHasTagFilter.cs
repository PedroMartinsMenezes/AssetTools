namespace AssetTool
{
    [JsonAsset("ActorHasTagFilter")]
    public class UActorHasTagFilter : UActorSelectorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}