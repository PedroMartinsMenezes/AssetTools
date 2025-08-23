namespace AssetTool
{
    [JsonAsset("VertexDeltaGraphDebugDataInterface")]
    public class UDEPRECATED_VertexDeltaGraphDebugDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VertexDeltaGraphDebugDataProvider")]
    public class UDEPRECATED_VertexDeltaGraphDebugDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}