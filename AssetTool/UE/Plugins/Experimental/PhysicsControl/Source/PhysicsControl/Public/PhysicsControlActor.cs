namespace AssetTool
{
    [JsonAsset("PhysicsControlInitializerComponent")]
    public class UPhysicsControlInitializerComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PhysicsControlActor")]
    public class APhysicsControlActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}