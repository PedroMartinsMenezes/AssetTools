namespace AssetTool
{
    [JsonAsset("NetworkPredictionExtrasFlyingPawn")]
    public class ANetworkPredictionExtrasFlyingPawn : APawn
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetworkPredictionExtrasFlyingPawn_MockAbility")]
    public class ANetworkPredictionExtrasFlyingPawn_MockAbility : ANetworkPredictionExtrasFlyingPawn
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}