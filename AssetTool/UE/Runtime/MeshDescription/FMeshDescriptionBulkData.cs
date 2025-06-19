namespace AssetTool
{
    public class FMeshDescriptionBulkData : ITransferible
    {
        public FByteBulkData TempBulkData;
        public FEditorBulkData BulkData;
        public FGuid Guid;
        public FBool bGuidIsHash;

        [Location("void FMeshDescriptionBulkData::Serialize( FArchive& Ar, UObject* Owner )")]
        public ITransferible Move2(Transfer transfer)
        {
            if (!transfer.Supports.VirtualizedBulkDataHaveUniqueGuids)
            {
                if (!transfer.Supports.MeshDescriptionVirtualization)
                {
                    TempBulkData ??= new();
                    TempBulkData.Move2(transfer);
                }
                else
                {
                    BulkData ??= new();
                    BulkData.Move2(transfer);
                }
            }
            else
            {
                BulkData ??= new();
                BulkData.Move2(transfer);
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
