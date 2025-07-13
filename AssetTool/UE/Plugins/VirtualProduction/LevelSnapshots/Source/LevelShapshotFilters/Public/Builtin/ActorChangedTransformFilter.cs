namespace AssetTool
{
    [JsonAsset("ActorChangedTransformFilter")]
    public class UActorChangedTransformFilter : UActorSelectorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}