namespace AssetTool
{
    [JsonAsset("PCGComputeKernel")]
    public class UPCGComputeKernel : UComputeKernel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}