namespace AssetTool
{
    [JsonAsset("AudioSubsystemCollectionRoot")]
    public class UAudioSubsystemCollectionRoot : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioEngineSubsystem")]
    public class UAudioEngineSubsystem : UDynamicSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}