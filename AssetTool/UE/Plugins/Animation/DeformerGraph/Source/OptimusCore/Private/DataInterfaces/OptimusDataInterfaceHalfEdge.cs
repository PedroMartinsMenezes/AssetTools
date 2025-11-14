namespace AssetTool
{
    [JsonAsset("OptimusHalfEdgeDataInterface")]
    public class UOptimusHalfEdgeDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusHalfEdgeDataProvider")]
    public class UOptimusHalfEdgeDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}