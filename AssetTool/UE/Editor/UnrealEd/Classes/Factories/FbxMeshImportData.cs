namespace AssetTool
{
    [JsonAsset("FbxMeshImportData")]
    public class UFbxMeshImportData : UFbxAssetImportData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}