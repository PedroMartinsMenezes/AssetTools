namespace AssetTool
{
    public class FRawMeshBulkData : ITransferable
    {
        public FByteBulkData BulkData;
        public FGuid Guid;
        public bool bGuidIsHash;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref BulkData);
            transfer.Move(ref Guid);
            transfer.Move(ref bGuidIsHash);
            return this;
        }
    }
}
