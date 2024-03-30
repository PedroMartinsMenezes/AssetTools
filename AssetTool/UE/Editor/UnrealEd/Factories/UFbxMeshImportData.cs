namespace AssetTool
{
    public class UFbxMeshImportData : UFbxAssetImportData
    {
        public new UFbxMeshImportData Read(BinaryReader reader)
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
