namespace AssetTool
{
    [JsonAsset("NetworkPredictionPhysicsComponent")]
    public class UNetworkPredictionPhysicsComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}