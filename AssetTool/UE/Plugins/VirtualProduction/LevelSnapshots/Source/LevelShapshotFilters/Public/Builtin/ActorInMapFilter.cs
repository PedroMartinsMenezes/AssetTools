namespace AssetTool
{
    [JsonAsset("ActorInMapFilter")]
    public class UActorInMapFilter : UActorSelectorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}