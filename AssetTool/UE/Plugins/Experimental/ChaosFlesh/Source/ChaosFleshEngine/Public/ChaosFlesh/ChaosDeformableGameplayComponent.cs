namespace AssetTool
{
    [JsonAsset("DeformableGameplayComponent")]
    public class UDeformableGameplayComponent : UDeformableTetrahedralComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}