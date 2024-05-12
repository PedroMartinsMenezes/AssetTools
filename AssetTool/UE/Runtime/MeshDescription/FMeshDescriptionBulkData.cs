namespace AssetTool
{
    [Location("void FMeshDescriptionBulkData::Serialize( FArchive& Ar, UObject* Owner )")]
    public class FMeshDescriptionBulkData
    {
        public FEditorBulkData BulkData = new();
        public FGuid Guid;
        public FBool bGuidIsHash;

        public FMeshDescriptionBulkData Move(Transfer transfer)
        {
            BulkData.Move(transfer);
            transfer.Move(ref Guid);
            transfer.Move(ref bGuidIsHash);
            return this;
        }
    }
}
