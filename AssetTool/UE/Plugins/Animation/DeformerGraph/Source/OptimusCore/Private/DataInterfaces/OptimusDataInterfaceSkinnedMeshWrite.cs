namespace AssetTool
{
    [JsonAsset("OptimusSkinnedMeshWriteDataInterface")]
    public class UOptimusSkinnedMeshWriteDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkinnedMeshWriteDataProvider")]
    public class UOptimusSkinnedMeshWriteDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}