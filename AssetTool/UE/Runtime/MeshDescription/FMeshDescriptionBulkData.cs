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
            if (!Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.VirtualizedBulkDataHaveUniqueGuids))
            {
                if (!Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.MeshDescriptionVirtualization))
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

            transfer.Move(ref Guid);
            transfer.Move(ref bGuidIsHash);
            return this;
        }
    }
}
