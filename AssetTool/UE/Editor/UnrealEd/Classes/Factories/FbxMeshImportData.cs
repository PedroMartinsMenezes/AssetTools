namespace AssetTool
{
    [JsonAsset("FbxMeshImportData")]
    public class UFbxMeshImportData : UFbxAssetImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}