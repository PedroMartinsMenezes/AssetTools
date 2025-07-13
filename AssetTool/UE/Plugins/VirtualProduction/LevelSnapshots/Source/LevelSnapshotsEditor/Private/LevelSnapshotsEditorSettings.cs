namespace AssetTool
{
    [JsonAsset("LevelSnapshotsEditorSettings")]
    public class ULevelSnapshotsEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}