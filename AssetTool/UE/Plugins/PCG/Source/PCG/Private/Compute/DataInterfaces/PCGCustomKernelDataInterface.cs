namespace AssetTool
{
    [JsonAsset("PCGCustomKernelDataInterface")]
    public class UPCGCustomKernelDataInterface : UComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGCustomComputeKernelDataProvider")]
    public class UPCGCustomComputeKernelDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}