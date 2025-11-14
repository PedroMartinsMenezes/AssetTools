namespace AssetTool
{
    [JsonAsset("NetworkPredictionPhysicsComponent")]
    public class UNetworkPredictionPhysicsComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}