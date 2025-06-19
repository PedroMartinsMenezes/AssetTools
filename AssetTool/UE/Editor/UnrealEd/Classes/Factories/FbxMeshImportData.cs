namespace AssetTool
{
    [JsonAsset("FbxMeshImportData")]
    public class UFbxMeshImportData : UFbxAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}