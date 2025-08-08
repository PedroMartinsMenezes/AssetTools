namespace AssetTool
{
    [JsonAsset("PCGMetadataPartitionDataInterface")]
    public class UPCGMetadataPartitionDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGMetaDataPartitionDataProvider")]
    public class UPCGMetaDataPartitionDataProvider : UPCGComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}