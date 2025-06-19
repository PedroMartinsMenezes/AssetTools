namespace AssetTool
{
    [JsonAsset("DEPRECATED_VertexDeltaGraphDebugDataInterface")]
    public class UDEPRECATED_VertexDeltaGraphDebugDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DEPRECATED_VertexDeltaGraphDebugDataProvider")]
    public class UDEPRECATED_VertexDeltaGraphDebugDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}