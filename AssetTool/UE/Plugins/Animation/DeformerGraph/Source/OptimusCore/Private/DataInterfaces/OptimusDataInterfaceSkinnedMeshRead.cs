namespace AssetTool
{
    [JsonAsset("OptimusSkinnedMeshReadDataInterface")]
    public class UOptimusSkinnedMeshReadDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkinnedMeshReadDataProvider")]
    public class UOptimusSkinnedMeshReadDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}