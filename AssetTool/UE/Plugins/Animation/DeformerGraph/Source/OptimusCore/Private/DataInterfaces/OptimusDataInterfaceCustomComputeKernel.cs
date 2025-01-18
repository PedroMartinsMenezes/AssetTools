namespace AssetTool
{
    [JsonAsset("OptimusCustomComputeKernelDataInterface")]
    public class UOptimusCustomComputeKernelDataInterface : UComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusCustomComputeKernelDataProvider")]
    public class UOptimusCustomComputeKernelDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}