namespace AssetTool
{
    [JsonAsset("PCGMetadataPartitionDataInterface")]
    public class UPCGMetadataPartitionDataInterface : UPCGComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGMetaDataPartitionDataProvider")]
    public class UPCGMetaDataPartitionDataProvider : UPCGComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}