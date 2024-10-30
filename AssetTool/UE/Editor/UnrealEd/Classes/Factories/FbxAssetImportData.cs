namespace AssetTool
{
    [JsonAsset("FbxAssetImportData")]
    public class UFbxAssetImportData : UAssetImportData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}