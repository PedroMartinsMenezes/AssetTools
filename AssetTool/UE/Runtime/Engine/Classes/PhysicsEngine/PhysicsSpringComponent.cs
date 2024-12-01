namespace AssetTool
{
    [JsonAsset("PhysicsSpringComponent")]
    public class UPhysicsSpringComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}