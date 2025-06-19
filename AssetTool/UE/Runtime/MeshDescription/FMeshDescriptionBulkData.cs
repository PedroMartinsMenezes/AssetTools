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
            if (!transfer.Supports.VirtualizedBulkDataHaveUniqueGuids)
            {
                if (!transfer.Supports.MeshDescriptionVirtualization)
                {
                    transfer.Move(ref TempBulkData);
                }
                else
                {
                    transfer.Move(ref BulkData);
                }
            }
            else
            {
                transfer.Move(ref BulkData);
            }
            if (transfer.Supports.MeshDescriptionBulkDataGuid)
            {
                transfer.Move(ref Guid);
            }
            if (transfer.Supports.MeshDescriptionBulkDataGuidIsHash)
            {
                transfer.Move(ref bGuidIsHash);
            }
            return this;
        }
    }
}
