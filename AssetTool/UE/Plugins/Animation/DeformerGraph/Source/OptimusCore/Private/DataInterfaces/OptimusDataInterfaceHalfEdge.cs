namespace AssetTool
{
    [JsonAsset("OptimusHalfEdgeDataInterface")]
    public class UOptimusHalfEdgeDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusHalfEdgeDataProvider")]
    public class UOptimusHalfEdgeDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}