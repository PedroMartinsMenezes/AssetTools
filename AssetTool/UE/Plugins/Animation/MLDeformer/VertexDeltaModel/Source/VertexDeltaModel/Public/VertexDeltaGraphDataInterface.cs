namespace AssetTool
{
    [JsonAsset("VertexDeltaGraphDataInterface")]
    public class UVertexDeltaGraphDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VertexDeltaGraphDataProvider")]
    public class UVertexDeltaGraphDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}