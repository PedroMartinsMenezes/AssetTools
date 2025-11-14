namespace AssetTool
{
    [JsonAsset("UsdAssetImportData")]
    public class UUsdAssetImportData : UAssetImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}