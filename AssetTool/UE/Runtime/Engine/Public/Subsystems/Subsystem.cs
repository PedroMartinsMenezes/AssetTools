namespace AssetTool
{
    [JsonAsset("Subsystem")]
    public class USubsystem : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DynamicSubsystem")]
    public class UDynamicSubsystem : USubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}