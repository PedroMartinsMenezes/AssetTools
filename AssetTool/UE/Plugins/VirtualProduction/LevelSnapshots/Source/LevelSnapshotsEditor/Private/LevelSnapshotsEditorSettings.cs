namespace AssetTool
{
    [JsonAsset("LevelSnapshotsEditorSettings")]
    public class ULevelSnapshotsEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}