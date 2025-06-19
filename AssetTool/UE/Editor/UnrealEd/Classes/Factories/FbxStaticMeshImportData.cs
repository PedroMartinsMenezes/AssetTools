namespace AssetTool
{
    [JsonAsset("FbxStaticMeshImportData")]
    public class UFbxStaticMeshImportData : UFbxMeshImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}