namespace AssetTool
{
    [JsonAsset("DeformableTetrahedralComponent")]
    public class UDeformableTetrahedralComponent : UDeformablePhysicsComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}