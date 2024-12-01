namespace AssetTool
{
    [JsonAsset("PhysicsConstraintComponent")]
    public class UPhysicsConstraintComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}