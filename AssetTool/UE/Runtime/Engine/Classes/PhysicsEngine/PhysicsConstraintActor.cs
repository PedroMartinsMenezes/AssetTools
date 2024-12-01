namespace AssetTool
{
    [JsonAsset("PhysicsConstraintActor")]
    public class APhysicsConstraintActor : ARigidBodyBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}