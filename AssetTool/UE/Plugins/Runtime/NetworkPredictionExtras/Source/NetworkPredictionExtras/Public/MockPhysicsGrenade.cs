namespace AssetTool
{
    [JsonAsset("MockPhysicsGrenadeComponent")]
    public class UMockPhysicsGrenadeComponent : UNetworkPredictionPhysicsComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}