namespace AssetTool
{
    [JsonAsset("LevelStreamingPersistentPropertiesInfo")]
    public class ULevelStreamingPersistentPropertiesInfo : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelStreamingPersistenceManager")]
    public class ULevelStreamingPersistenceManager : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}