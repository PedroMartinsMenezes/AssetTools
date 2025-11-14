namespace AssetTool
{
    [JsonAsset("OptimusSkinnedMeshVertexAttributeDataInterface")]
    public class UOptimusSkinnedMeshVertexAttributeDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusSkinnedMeshVertexAttributeDataProvider")]
    public class UOptimusSkinnedMeshVertexAttributeDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}