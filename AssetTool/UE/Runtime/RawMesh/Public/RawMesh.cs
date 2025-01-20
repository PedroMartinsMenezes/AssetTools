namespace AssetTool
{
    public class FRawMeshBulkData : ITransferible
    {
        public FByteBulkData BulkData;
        public FGuid Guid;
        public FBool bGuidIsHash;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref BulkData);
            transfer.Move(ref Guid);
            transfer.Move(ref bGuidIsHash);
            return this;
        }
    }
}
