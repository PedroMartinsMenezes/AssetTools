namespace AssetTool
{
    [JsonAsset("NetworkPredictionComponent")]
    public class UNetworkPredictionComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}