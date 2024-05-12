namespace AssetTool
{
    public class UFbxMeshImportData : UFbxAssetImportData
    {
        public new UFbxMeshImportData Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
