namespace AssetTool
{
    [JsonAsset("PhysicsControlInitializerComponent")]
    public class UPhysicsControlInitializerComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PhysicsControlActor")]
    public class APhysicsControlActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}