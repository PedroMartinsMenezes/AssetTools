namespace AssetTool
{
    [JsonAsset("OptimusSkinnedMeshVertexAttributeDataInterface")]
    public class UOptimusSkinnedMeshVertexAttributeDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkinnedMeshVertexAttributeDataProvider")]
    public class UOptimusSkinnedMeshVertexAttributeDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}