namespace AssetTool
{
    [JsonAsset("OptimusCopyKernelDataInterface")]
    public class UOptimusCopyKernelDataInterface : UComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusCopyKernelDataProvider")]
    public class UOptimusCopyKernelDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}