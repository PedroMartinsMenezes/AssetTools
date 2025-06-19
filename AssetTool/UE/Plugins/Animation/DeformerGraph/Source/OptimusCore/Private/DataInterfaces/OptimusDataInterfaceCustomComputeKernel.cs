namespace AssetTool
{
    [JsonAsset("OptimusCustomComputeKernelDataInterface")]
    public class UOptimusCustomComputeKernelDataInterface : UComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusCustomComputeKernelDataProvider")]
    public class UOptimusCustomComputeKernelDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}