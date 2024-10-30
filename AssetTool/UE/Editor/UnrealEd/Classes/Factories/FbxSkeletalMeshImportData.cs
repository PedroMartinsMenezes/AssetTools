namespace AssetTool
{
    [JsonAsset("FbxSkeletalMeshImportData")]
    public class UFbxSkeletalMeshImportData : UFbxMeshImportData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}