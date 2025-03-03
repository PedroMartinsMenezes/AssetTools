namespace AssetTool
{
    [JsonAsset("PCGMetadataPartitionSettings")]
    public class UPCGMetadataPartitionSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}