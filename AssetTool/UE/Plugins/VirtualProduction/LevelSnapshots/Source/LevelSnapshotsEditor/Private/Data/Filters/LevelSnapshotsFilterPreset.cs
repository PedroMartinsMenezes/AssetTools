namespace AssetTool
{
    [JsonAsset("LevelSnapshotsFilterPreset")]
    public class ULevelSnapshotsFilterPreset : ULevelSnapshotFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}