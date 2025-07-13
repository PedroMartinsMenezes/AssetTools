namespace AssetTool
{
    [JsonAsset("GroomCacheImportOptions")]
    public class UGroomCacheImportOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroomCacheImportData")]
    public class UGroomCacheImportData : UAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}