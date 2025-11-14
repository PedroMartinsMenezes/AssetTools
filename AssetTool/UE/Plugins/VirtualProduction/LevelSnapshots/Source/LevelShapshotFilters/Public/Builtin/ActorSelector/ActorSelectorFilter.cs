namespace AssetTool
{
    [JsonAsset("ActorSelectorFilter")]
    public class UActorSelectorFilter : ULevelSnapshotBlueprintFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}