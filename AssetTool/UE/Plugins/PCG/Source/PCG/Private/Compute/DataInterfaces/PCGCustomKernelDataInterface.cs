namespace AssetTool
{
    [JsonAsset("PCGCustomKernelDataInterface")]
    public class UPCGCustomKernelDataInterface : UComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGCustomComputeKernelDataProvider")]
    public class UPCGCustomComputeKernelDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}