namespace AssetTool
{
    [JsonAsset("PhysicsSpringComponent")]
    public class UPhysicsSpringComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}