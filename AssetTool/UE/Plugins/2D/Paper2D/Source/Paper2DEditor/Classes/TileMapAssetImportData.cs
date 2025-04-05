namespace AssetTool
{
    [JsonAsset("TileMapAssetImportData")]
    public class UTileMapAssetImportData : UAssetImportData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}