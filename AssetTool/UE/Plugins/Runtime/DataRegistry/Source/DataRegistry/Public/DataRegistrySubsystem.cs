namespace AssetTool
{
    [JsonAsset("DataRegistrySubsystem")]
    public class UDataRegistrySubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataRegistryTestActor")]
    public class ADataRegistryTestActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}