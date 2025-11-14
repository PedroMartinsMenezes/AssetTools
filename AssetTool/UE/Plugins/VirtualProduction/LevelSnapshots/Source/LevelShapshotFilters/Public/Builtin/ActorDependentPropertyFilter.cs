namespace AssetTool
{
    [JsonAsset("ActorDependentPropertyFilter")]
    public class UActorDependentPropertyFilter : ULevelSnapshotFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}