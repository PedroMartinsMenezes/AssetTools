namespace AssetTool
{
    [JsonAsset("ActorHasTagFilter")]
    public class UActorHasTagFilter : UActorSelectorFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}