namespace AssetTool
{
    [JsonAsset("NetworkPredictionWorldManager")]
    public class UNetworkPredictionWorldManager : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}