namespace AssetTool
{
    [JsonAsset("LevelSnapshotsEditorData")]
    public class ULevelSnapshotsEditorData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}