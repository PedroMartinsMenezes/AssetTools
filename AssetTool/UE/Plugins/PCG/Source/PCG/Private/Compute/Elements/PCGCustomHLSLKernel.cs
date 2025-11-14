namespace AssetTool
{
    [JsonAsset("PCGCustomHLSLKernel")]
    public class UPCGCustomHLSLKernel : UPCGComputeKernel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}