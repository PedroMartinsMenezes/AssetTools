namespace AssetTool
{
    [JsonAsset("NetworkSubsystem")]
    public class UNetworkSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}