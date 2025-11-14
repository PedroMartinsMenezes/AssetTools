namespace AssetTool
{
    [JsonAsset("OptimusCustomComputeKernelDataInterface")]
    public class UOptimusCustomComputeKernelDataInterface : UComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusCustomComputeKernelDataProvider")]
    public class UOptimusCustomComputeKernelDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}