namespace AssetTool
{
    [JsonAsset("PCGMetadataPartitionKernel")]
    public class UPCGMetadataPartitionKernel : UPCGComputeKernel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}