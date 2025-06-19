namespace AssetTool
{
    [JsonAsset("NetworkPredictionWorldManager")]
    public class UNetworkPredictionWorldManager : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}