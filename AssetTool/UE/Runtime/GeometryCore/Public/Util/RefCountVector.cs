namespace AssetTool.Geometry
{
    public class FRefCountVector : ITransferible<bool, bool>
    {
        public TDynamicVector<TUInt16> RefCounts;
        public TDynamicVector<TInt32> FreeIndices;
        public int UsedCount;
        public FBool bCompactData;
        public FBool bUseCompression;

        public ITransferible Move(Transfer transfer)
        {
            return Move(transfer, false, false);
        }

        public ITransferible Move(Transfer transfer, bool compactData, bool useCompression)
        {
            if (!transfer.Supports.DynamicMeshCompactedSerialization)
            {
                transfer.Move(ref RefCounts);
                transfer.Move(ref FreeIndices);
                transfer.Move(ref UsedCount);
            }
            else
            {
                transfer.Move(ref bCompactData);
                transfer.Move(ref bUseCompression);
                transfer.Move(ref UsedCount);
                transfer.Move(ref RefCounts, true, bUseCompression.Value);
            }
            return this;
        }
    }
}
