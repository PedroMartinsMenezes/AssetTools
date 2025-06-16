namespace AssetTool
{
    [JsonAsset("PCGDataCollectionExporter")]
    public class UPCGDataCollectionExporter : UPCGAssetExporter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSaveDataAssetSettings")]
    public class UPCGSaveDataAssetSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}