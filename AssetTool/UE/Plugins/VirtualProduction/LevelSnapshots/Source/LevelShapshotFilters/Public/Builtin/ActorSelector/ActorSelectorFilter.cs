namespace AssetTool
{
    [JsonAsset("ActorSelectorFilter")]
    public class UActorSelectorFilter : ULevelSnapshotBlueprintFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}