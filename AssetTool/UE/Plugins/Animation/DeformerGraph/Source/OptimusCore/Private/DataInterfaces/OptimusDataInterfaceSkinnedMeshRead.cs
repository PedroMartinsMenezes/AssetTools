namespace AssetTool
{
    [JsonAsset("OptimusSkinnedMeshReadDataInterface")]
    public class UOptimusSkinnedMeshReadDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkinnedMeshReadDataProvider")]
    public class UOptimusSkinnedMeshReadDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}