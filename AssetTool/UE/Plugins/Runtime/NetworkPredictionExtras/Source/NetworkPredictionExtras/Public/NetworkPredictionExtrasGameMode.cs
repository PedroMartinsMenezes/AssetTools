namespace AssetTool
{
    [JsonAsset("NetworkPredictionExtrasGameMode")]
    public class ANetworkPredictionExtrasGameMode : AGameMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}