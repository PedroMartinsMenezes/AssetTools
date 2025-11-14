namespace AssetTool
{
    [JsonAsset("OptimusSkinnedMeshDataInterface")]
    public class UOptimusSkinnedMeshDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkinnedMeshDataProvider")]
    public class UOptimusSkinnedMeshDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}