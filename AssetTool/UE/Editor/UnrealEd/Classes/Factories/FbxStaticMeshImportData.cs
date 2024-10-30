namespace AssetTool
{
    [JsonAsset("FbxStaticMeshImportData")]
    public class UFbxStaticMeshImportData : UFbxMeshImportData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}