namespace AssetTool
{
    [JsonAsset("FbxStaticMeshImportData")]
    public class UFbxStaticMeshImportData : UFbxMeshImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}