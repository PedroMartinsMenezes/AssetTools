namespace AssetTool
{
    [JsonAsset("DeformableConstraintsComponent")]
    public class UDeformableConstraintsComponent : UDeformablePhysicsComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}