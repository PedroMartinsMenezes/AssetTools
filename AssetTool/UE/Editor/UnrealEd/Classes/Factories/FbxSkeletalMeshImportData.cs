namespace AssetTool
{
    [JsonAsset("FbxSkeletalMeshImportData")]
    public class UFbxSkeletalMeshImportData : UFbxMeshImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}