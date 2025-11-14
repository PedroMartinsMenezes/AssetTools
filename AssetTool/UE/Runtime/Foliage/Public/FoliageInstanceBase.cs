namespace AssetTool
{
    public class FFoliageInstanceBaseCache : ITransferable
    {
        public Int32 NextBaseId;
        public Dictionary<TInt32, FFoliageInstanceBaseInfo> InstanceBaseMap;
        public List<TTuple<FSoftObjectPtr, TList<FLazyObjectPtr>>> InstanceBaseLevelMap_DEPRECATED;
        public List<TTuple<FSoftObjectPtr, TList<FSoftObjectPtr>>> InstanceBaseLevelMap;

        [Location("FArchive& operator << (FArchive& Ar, FFoliageInstanceBaseCache& InstanceBaseCache)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref NextBaseId);
            transfer.Move(ref InstanceBaseMap);
            if (!transfer.Supports.FoliageLazyObjPtrToSoftObjPtr)
                transfer.Move(ref InstanceBaseLevelMap_DEPRECATED);
            else
                transfer.Move(ref InstanceBaseLevelMap);
            return this;
        }
    }

    public class FFoliageInstanceBaseInfo : ITransferable
    {
        public FLazyObjectPtr BasePtr_DEPRECATED;
        public FSoftObjectPtr BasePtr;
        public FVector CachedLocation;
        public FRotator CachedRotation;
        public FVector CachedDrawScale;

        [Location("FArchive& operator << (FArchive& Ar, FFoliageInstanceBaseInfo& BaseInfo)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.FoliageLazyObjPtrToSoftObjPtr)
                transfer.Move(ref BasePtr_DEPRECATED);
            else
                transfer.Move(ref BasePtr);
            transfer.Move(ref CachedLocation);
            transfer.Move(ref CachedRotation);
            transfer.Move(ref CachedDrawScale);
            return this;
        }
    }
}
