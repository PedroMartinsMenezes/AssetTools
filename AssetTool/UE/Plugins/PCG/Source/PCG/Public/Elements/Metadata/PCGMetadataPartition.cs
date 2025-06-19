namespace AssetTool
{
    [JsonAsset("PCGMetadataPartitionSettings")]
    public class UPCGMetadataPartitionSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}