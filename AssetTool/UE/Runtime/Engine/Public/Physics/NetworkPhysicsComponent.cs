namespace AssetTool
{
    [JsonAsset("NetworkPhysicsSystem")]
    public class UNetworkPhysicsSystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetworkPhysicsComponent")]
    public class UNetworkPhysicsComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}