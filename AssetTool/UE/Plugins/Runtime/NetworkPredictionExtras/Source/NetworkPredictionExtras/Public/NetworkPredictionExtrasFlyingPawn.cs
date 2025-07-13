namespace AssetTool
{
    [JsonAsset("NetworkPredictionExtrasFlyingPawn")]
    public class ANetworkPredictionExtrasFlyingPawn : APawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetworkPredictionExtrasFlyingPawn_MockAbility")]
    public class ANetworkPredictionExtrasFlyingPawn_MockAbility : ANetworkPredictionExtrasFlyingPawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}