namespace AssetTool
{
    public class FInlineReductionCacheData : ITransferable
    {
        public UInt32 CacheLODVertexCount;
        public UInt32 CacheLODTriCount;

        [Location("FORCEINLINE FArchive& operator<<(FArchive& Ar, FInlineReductionCacheData& InlineReductionCacheData)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref CacheLODVertexCount);
            transfer.Move(ref CacheLODTriCount);
            return this;
        }
    }
}
