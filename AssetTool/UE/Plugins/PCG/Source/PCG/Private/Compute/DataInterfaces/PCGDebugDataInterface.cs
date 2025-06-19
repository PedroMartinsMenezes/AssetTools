namespace AssetTool
{
    [JsonAsset("PCGDebugDataInterface")]
    public class UPCGDebugDataInterface : UComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDebugDataProvider")]
    public class UPCGDebugDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}