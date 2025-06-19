namespace AssetTool
{
    [JsonAsset("PCGCustomKernelDataInterface")]
    public class UPCGCustomKernelDataInterface : UComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGCustomComputeKernelDataProvider")]
    public class UPCGCustomComputeKernelDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}