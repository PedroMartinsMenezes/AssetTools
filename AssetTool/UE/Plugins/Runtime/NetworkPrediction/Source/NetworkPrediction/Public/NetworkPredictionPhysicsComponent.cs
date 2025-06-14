namespace AssetTool
{
    [JsonAsset("NetworkPredictionPhysicsComponent")]
    public class UNetworkPredictionPhysicsComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}