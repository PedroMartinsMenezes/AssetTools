namespace AssetTool
{
    [JsonAsset("LevelSnapshotsSettings")]
    public class ULevelSnapshotsSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}