namespace AssetTool
{
    [JsonAsset("NetworkSubsystem")]
    public class UNetworkSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}