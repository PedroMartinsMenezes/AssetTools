namespace AssetTool
{
    [JsonAsset("OptimusSkinnedMeshExecDataInterface")]
    public class UOptimusSkinnedMeshExecDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkinnedMeshExecDataProvider")]
    public class UOptimusSkinnedMeshExecDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}