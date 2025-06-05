namespace AssetTool
{
    [JsonAsset("DeformableTetrahedralComponent")]
    public class UDeformableTetrahedralComponent : UDeformablePhysicsComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}