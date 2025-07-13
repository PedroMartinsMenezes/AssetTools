namespace AssetTool
{
    [JsonAsset("MockPhysicsGrenadeComponent")]
    public class UMockPhysicsGrenadeComponent : UNetworkPredictionPhysicsComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}