namespace AssetTool
{
    [JsonAsset("AudioSubsystemCollectionRoot")]
    public class UAudioSubsystemCollectionRoot : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioEngineSubsystem")]
    public class UAudioEngineSubsystem : UDynamicSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}