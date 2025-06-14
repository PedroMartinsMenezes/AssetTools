namespace AssetTool
{
    [JsonAsset("NetworkPredictionWorldManager")]
    public class UNetworkPredictionWorldManager : UWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}