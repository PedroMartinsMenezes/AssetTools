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
            var transfer = GlobalObjects.Transfer;
            BulkData = new FEditorBulkData().Read(reader);
            transfer.Move(ref Guid);
            transfer.Move(ref bGuidIsHash);
            return this;
        }

        public void Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;
            BulkData.Write(writer);
            transfer.Move(ref Guid);
            transfer.Move(ref bGuidIsHash);
        }
    }
}
