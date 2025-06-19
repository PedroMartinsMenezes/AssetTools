namespace AssetTool
{
    [JsonAsset("OptimusCopyKernelDataInterface")]
    public class UOptimusCopyKernelDataInterface : UComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusCopyKernelDataProvider")]
    public class UOptimusCopyKernelDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}