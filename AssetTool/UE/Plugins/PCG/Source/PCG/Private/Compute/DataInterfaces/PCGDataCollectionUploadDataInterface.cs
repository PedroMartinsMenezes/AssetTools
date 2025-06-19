namespace AssetTool
{
    [JsonAsset("PCGDataCollectionUploadDataInterface")]
    public class UPCGDataCollectionUploadDataInterface : UPCGDataCollectionDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataProviderDataCollectionUpload")]
    public class UPCGDataProviderDataCollectionUpload : UPCGDataCollectionDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}