namespace AssetTool
{
    [JsonAsset("PCGCustomHLSLKernel")]
    public class UPCGCustomHLSLKernel : UPCGComputeKernel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}