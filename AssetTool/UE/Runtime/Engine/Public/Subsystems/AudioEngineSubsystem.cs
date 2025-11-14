namespace AssetTool
{
    [JsonAsset("AudioSubsystemCollectionRoot")]
    public class UAudioSubsystemCollectionRoot : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AudioEngineSubsystem")]
    public class UAudioEngineSubsystem : UDynamicSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}