namespace AssetTool
{
    [JsonAsset("UsdAssetImportData")]
    public class UUsdAssetImportData : UAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}