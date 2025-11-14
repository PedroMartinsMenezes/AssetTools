namespace AssetTool
{
    [JsonAsset("MoverNetworkPredictionLiaisonComponent")]
    public class UMoverNetworkPredictionLiaisonComponent : UNetworkPredictionComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}