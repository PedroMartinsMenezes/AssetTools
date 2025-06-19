namespace AssetTool
{
    [JsonAsset("DeformableTetrahedralComponent")]
    public class UDeformableTetrahedralComponent : UDeformablePhysicsComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}