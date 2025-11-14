namespace AssetTool
{
    [JsonAsset("LevelSnapshotsFilterPreset")]
    public class ULevelSnapshotsFilterPreset : ULevelSnapshotFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}