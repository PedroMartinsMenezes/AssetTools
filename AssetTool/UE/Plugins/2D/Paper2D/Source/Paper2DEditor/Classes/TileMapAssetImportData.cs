namespace AssetTool
{
    [JsonAsset("TileMapAssetImportData")]
    public class UTileMapAssetImportData : UAssetImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}