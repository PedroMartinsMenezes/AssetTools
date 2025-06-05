namespace AssetTool
{
    [JsonAsset("DeformableConstraintsComponent")]
    public class UDeformableConstraintsComponent : UDeformablePhysicsComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}