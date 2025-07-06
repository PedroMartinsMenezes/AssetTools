namespace AssetTool
{
    [JsonAsset("RCPropertyContainerBase")]
    public class URCPropertyContainerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RCPropertyContainerRegistry")]
    public class URCPropertyContainerRegistry : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}