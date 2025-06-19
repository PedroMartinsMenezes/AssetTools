namespace AssetTool
{
    [JsonAsset("DeformableGameplayComponent")]
    public class UDeformableGameplayComponent : UDeformableTetrahedralComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}