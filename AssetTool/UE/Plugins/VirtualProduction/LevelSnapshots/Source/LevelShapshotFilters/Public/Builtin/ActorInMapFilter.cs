namespace AssetTool
{
    [JsonAsset("ActorInMapFilter")]
    public class UActorInMapFilter : UActorSelectorFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}