namespace AssetTool
{
    [JsonAsset("LevelStreamingPersistenceSettings")]
    public class ULevelStreamingPersistenceSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}