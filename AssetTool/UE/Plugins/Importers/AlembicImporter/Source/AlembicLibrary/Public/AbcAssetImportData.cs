namespace AssetTool
{
    [JsonAsset("AbcAssetImportData")]
    public class UAbcAssetImportData : UAssetImportData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}