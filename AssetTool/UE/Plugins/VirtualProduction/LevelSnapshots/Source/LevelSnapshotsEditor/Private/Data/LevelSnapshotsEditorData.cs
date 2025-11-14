namespace AssetTool
{
    [JsonAsset("LevelSnapshotsEditorData")]
    public class ULevelSnapshotsEditorData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}