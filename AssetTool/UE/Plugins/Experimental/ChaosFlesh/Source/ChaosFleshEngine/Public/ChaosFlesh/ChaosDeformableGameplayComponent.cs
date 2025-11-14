namespace AssetTool
{
    [JsonAsset("DeformableGameplayComponent")]
    public class UDeformableGameplayComponent : UDeformableTetrahedralComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}