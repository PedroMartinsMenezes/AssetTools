namespace AssetTool
{
    [JsonAsset("PhysicsConstraintTemplate")]
    public class UPhysicsConstraintTemplate : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}