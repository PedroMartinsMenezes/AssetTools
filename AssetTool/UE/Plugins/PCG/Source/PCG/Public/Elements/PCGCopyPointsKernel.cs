namespace AssetTool
{
    [JsonAsset("PCGCopyPointsKernel")]
    public class UPCGCopyPointsKernel : UPCGComputeKernel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}