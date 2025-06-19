namespace AssetTool
{
    [JsonAsset("DeformableConstraintsComponent")]
    public class UDeformableConstraintsComponent : UDeformablePhysicsComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}