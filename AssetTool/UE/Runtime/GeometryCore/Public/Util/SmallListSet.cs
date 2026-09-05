namespace AssetTool.Geometry
{
    public class FSmallListSet : ITransferable
    {
        #region
        public TDynamicVector<TInt32> ListHeads;
        public TDynamicVector<TInt32> ListBlocks;
        public TDynamicVector<TInt32> FreeBlocks;
        public int32 AllocatedCount;
        public TDynamicVector<TInt32> LinkedListElements;
        public int32 FreeHeadIndex;
        #endregion
        #region
        public bool bCompactData;
        public bool bUseCompression;
        public TDynamicVector<TInt32> Buffer;
        #endregion

        [Location("void FSmallListSet::Serialize(FArchive& Ar, bool bCompactData, bool bUseCompression)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.DynamicMeshCompactedSerialization)
            {
                transfer.Move(ref ListHeads);
                transfer.Move(ref ListBlocks);
                transfer.Move(ref FreeBlocks);
                transfer.Move(ref AllocatedCount);
                transfer.Move(ref LinkedListElements);
                transfer.Move(ref FreeHeadIndex);
            }
            else
            {
                transfer.Move(ref bCompactData);
                transfer.Move(ref bUseCompression);
                if (bCompactData || bUseCompression)
                {
                    transfer.Move(ref Buffer, true, bUseCompression);
                }
                else
                {
                    SerializeVector(transfer, ref ListHeads, false);
                    SerializeVector(transfer, ref ListBlocks, false);
                    SerializeVector(transfer, ref FreeBlocks, false);
                    SerializeVector(transfer, ref LinkedListElements, false);
                    transfer.Move(ref AllocatedCount);
                    transfer.Move(ref FreeHeadIndex);
                }
            }
            return this;
        }

        public static void SerializeVector(Transfer transfer, ref TDynamicVector<TInt32> vector, bool bUseCompression)
        {
            transfer.Move(ref vector, true, bUseCompression);
        }
    }
}
