namespace AssetTool
{
    [JsonAsset("PCGComputeKernel")]
    public class UPCGComputeKernel : UComputeKernel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}