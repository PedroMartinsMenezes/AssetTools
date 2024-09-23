namespace AssetTool
{
    public class FInlineReductionCacheData
    {
        public UInt32 CacheLODVertexCount;
        public UInt32 CacheLODTriCount;

        [Location("FORCEINLINE FArchive& operator<<(FArchive& Ar, FInlineReductionCacheData& InlineReductionCacheData)")]
        public void Move(Transfer transfer)
        {
            transfer.Move(ref CacheLODVertexCount);
            transfer.Move(ref CacheLODTriCount);
        }
    }
}
