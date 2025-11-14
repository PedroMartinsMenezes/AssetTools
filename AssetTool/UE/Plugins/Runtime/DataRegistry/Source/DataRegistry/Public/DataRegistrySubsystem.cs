namespace AssetTool
{
    [JsonAsset("DataRegistrySubsystem")]
    public class UDataRegistrySubsystem : UEngineSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataRegistryTestActor")]
    public class ADataRegistryTestActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}