namespace AssetTool
{
    public class UFbxStaticMeshImportData : UFbxMeshImportData
    {
        public new const string TypeName = "FbxStaticMeshImportData";

        public new UFbxStaticMeshImportData Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
