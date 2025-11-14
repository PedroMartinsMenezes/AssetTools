namespace AssetTool
{
    [JsonAsset("PhysicsConstraintActor")]
    public class APhysicsConstraintActor : ARigidBodyBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}