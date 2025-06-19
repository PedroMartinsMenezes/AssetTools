namespace AssetTool
{
    [JsonAsset("Subsystem")]
    public class USubsystem : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DynamicSubsystem")]
    public class UDynamicSubsystem : USubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}