namespace AssetTool
{
    [JsonAsset("LevelSnapshotFilter")]
    public class ULevelSnapshotFilter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelSnapshotBlueprintFilter")]
    public class ULevelSnapshotBlueprintFilter : ULevelSnapshotFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}