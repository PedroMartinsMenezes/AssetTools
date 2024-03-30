namespace AssetTool
{
    public class UFbxAssetImportData : UAssetImportData
    {
        public new UFbxAssetImportData Read(BinaryReader reader)
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
