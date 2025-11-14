namespace AssetTool
{
    [JsonAsset("ActorChangedTransformFilter")]
    public class UActorChangedTransformFilter : UActorSelectorFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}