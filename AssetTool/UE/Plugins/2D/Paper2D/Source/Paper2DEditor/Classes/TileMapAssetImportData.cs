namespace AssetTool
{
    [JsonAsset("TileMapAssetImportData")]
    public class UTileMapAssetImportData : UAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}