namespace AssetTool
{
    public class FInlineReductionCacheData : ITransferible
    {
        public UInt32 CacheLODVertexCount;
        public UInt32 CacheLODTriCount;

        [Location("FORCEINLINE FArchive& operator<<(FArchive& Ar, FInlineReductionCacheData& InlineReductionCacheData)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref CacheLODVertexCount);
            transfer.Move(ref CacheLODTriCount);
            return this;
        }
    }
}
