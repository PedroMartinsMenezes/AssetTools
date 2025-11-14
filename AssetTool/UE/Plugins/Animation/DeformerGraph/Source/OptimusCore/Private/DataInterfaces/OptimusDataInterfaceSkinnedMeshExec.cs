namespace AssetTool
{
    [JsonAsset("OptimusSkinnedMeshExecDataInterface")]
    public class UOptimusSkinnedMeshExecDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkinnedMeshExecDataProvider")]
    public class UOptimusSkinnedMeshExecDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}