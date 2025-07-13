namespace AssetTool
{
    [JsonAsset("NetworkPredictionExtrasCharacter")]
    public class ANetworkPredictionExtrasCharacter : APawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetworkPredictionExtrasCharacter_MockAbility")]
    public class ANetworkPredictionExtrasCharacter_MockAbility : ANetworkPredictionExtrasCharacter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}