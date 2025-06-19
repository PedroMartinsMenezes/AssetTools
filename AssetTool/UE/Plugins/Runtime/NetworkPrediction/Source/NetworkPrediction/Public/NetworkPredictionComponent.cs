namespace AssetTool
{
    [JsonAsset("NetworkPredictionComponent")]
    public class UNetworkPredictionComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}