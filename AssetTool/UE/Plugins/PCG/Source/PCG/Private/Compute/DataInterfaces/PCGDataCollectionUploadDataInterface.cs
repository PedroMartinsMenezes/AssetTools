namespace AssetTool
{
    [JsonAsset("PCGDataCollectionUploadDataInterface")]
    public class UPCGDataCollectionUploadDataInterface : UPCGDataCollectionDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataProviderDataCollectionUpload")]
    public class UPCGDataProviderDataCollectionUpload : UPCGDataCollectionDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}