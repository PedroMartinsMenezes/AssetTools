namespace AssetTool
{
    public class UFbxStaticMeshImportData : UFbxMeshImportData
    {
        public new const string TypeName = "FbxStaticMeshImportData";

        public new UFbxStaticMeshImportData Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
