namespace AssetTool
{
    [JsonAsset("LevelSnapshotsSettings")]
    public class ULevelSnapshotsSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}