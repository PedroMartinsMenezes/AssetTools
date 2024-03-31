namespace AssetTool
{
    [Location("void FMeshDescriptionBulkData::Serialize( FArchive& Ar, UObject* Owner )")]
    public class FMeshDescriptionBulkData
    {
        public FEditorBulkData BulkData;
        public FGuid Guid;
        public FBool bGuidIsHash;

        public FMeshDescriptionBulkData Read(BinaryReader reader)
        {
            BulkData = new FEditorBulkData().Read(reader);
            reader.Read(ref Guid);
            reader.Read(ref bGuidIsHash);
            return this;
        }

        public void Write(BinaryWriter writer)
        {
            BulkData.Write(writer);
            writer.Write(Guid);
            writer.Write(bGuidIsHash);
        }
    }
}
