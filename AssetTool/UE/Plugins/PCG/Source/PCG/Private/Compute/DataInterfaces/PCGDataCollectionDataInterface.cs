namespace AssetTool
{
    [JsonAsset("PCGDataCollectionDataInterface")]
    public class UPCGDataCollectionDataInterface : UPCGComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataCollectionDataProvider")]
    public class UPCGDataCollectionDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}