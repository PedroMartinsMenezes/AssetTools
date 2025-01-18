namespace AssetTool
{
    [JsonAsset("OptimusSkinnedMeshWriteDataInterface")]
    public class UOptimusSkinnedMeshWriteDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkinnedMeshWriteDataProvider")]
    public class UOptimusSkinnedMeshWriteDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}