namespace AssetTool
{
    [JsonAsset("LevelSnapshotFilter")]
    public class ULevelSnapshotFilter : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelSnapshotBlueprintFilter")]
    public class ULevelSnapshotBlueprintFilter : ULevelSnapshotFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}