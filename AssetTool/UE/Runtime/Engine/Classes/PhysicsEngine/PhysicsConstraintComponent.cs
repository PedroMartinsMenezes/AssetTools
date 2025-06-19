namespace AssetTool
{
    [JsonAsset("PhysicsConstraintComponent")]
    public class UPhysicsConstraintComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}