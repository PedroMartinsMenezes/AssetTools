namespace AssetTool
{
    [JsonAsset("PCGMetadataPartitionSettings")]
    public class UPCGMetadataPartitionSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}