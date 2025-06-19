namespace AssetTool
{
    [JsonAsset("PhysicsConstraintActor")]
    public class APhysicsConstraintActor : ARigidBodyBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}