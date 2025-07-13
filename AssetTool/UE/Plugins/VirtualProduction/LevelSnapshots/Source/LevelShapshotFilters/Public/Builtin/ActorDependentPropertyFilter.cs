namespace AssetTool
{
    [JsonAsset("ActorDependentPropertyFilter")]
    public class UActorDependentPropertyFilter : ULevelSnapshotFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}