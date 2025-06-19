namespace AssetTool
{
    [JsonAsset("PCGDataCollectionExporter")]
    public class UPCGDataCollectionExporter : UPCGAssetExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSaveDataAssetSettings")]
    public class UPCGSaveDataAssetSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}