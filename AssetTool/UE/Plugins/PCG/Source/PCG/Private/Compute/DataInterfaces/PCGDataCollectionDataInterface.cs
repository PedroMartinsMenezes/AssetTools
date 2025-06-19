namespace AssetTool
{
    [JsonAsset("PCGDataCollectionDataInterface")]
    public class UPCGDataCollectionDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataCollectionDataProvider")]
    public class UPCGDataCollectionDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}