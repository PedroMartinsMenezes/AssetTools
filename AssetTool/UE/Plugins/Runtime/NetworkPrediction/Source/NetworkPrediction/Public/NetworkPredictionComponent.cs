namespace AssetTool
{
    [JsonAsset("NetworkPredictionComponent")]
    public class UNetworkPredictionComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}