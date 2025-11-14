namespace AssetTool
{
    [JsonAsset("RCPropertyContainerBase")]
    public class URCPropertyContainerBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RCPropertyContainerRegistry")]
    public class URCPropertyContainerRegistry : UEngineSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}