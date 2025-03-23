namespace AssetTool
{
    public class FMeshDescriptionBulkData : ITransferible
    {
        public FByteBulkData TempBulkData;
        public FEditorBulkData BulkData;
        public FGuid Guid;
        public FBool bGuidIsHash;

        [Location("void FMeshDescriptionBulkData::Serialize( FArchive& Ar, UObject* Owner )")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.VirtualizedBulkDataHaveUniqueGuids)
            {
                if (!Supports.MeshDescriptionVirtualization)
                {
                    TempBulkData ??= new();
                    TempBulkData.Move(transfer);
                }
                else
                {
                    BulkData ??= new();
                    BulkData.Move(transfer);
                }
            }
            else
            {
                BulkData ??= new();
                BulkData.Move(transfer);
            }
            if (Supports.MeshDescriptionBulkDataGuid)
            {
                transfer.Move(ref Guid);
            }
            if (Supports.MeshDescriptionBulkDataGuidIsHash)
            {
                transfer.Move(ref bGuidIsHash);
            }
            return this;
        }
    }
}
