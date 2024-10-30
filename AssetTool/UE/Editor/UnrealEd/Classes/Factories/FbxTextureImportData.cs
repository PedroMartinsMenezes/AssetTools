namespace AssetTool
{
    [JsonAsset("FbxTextureImportData")]
    public class UFbxTextureImportData : UFbxAssetImportData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}