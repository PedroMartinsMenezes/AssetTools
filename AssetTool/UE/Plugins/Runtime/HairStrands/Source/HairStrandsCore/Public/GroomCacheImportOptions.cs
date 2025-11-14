namespace AssetTool
{
    [JsonAsset("GroomCacheImportOptions")]
    public class UGroomCacheImportOptions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroomCacheImportData")]
    public class UGroomCacheImportData : UAssetImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}