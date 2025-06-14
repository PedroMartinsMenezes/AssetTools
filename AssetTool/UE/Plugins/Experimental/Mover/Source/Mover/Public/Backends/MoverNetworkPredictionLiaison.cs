namespace AssetTool
{
    [JsonAsset("MoverNetworkPredictionLiaisonComponent")]
    public class UMoverNetworkPredictionLiaisonComponent : UNetworkPredictionComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}