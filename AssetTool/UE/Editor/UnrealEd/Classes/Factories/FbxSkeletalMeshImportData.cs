namespace AssetTool
{
    [JsonAsset("FbxSkeletalMeshImportData")]
    public class UFbxSkeletalMeshImportData : UFbxMeshImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}