namespace AssetTool
{
    [JsonAsset("OptimusCopyKernelDataInterface")]
    public class UOptimusCopyKernelDataInterface : UComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusCopyKernelDataProvider")]
    public class UOptimusCopyKernelDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}