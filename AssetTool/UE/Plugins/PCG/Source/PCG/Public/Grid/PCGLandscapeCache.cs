namespace AssetTool
{
    [JsonAsset("PCGLandscapeCache")]
    public class UPCGLandscapeCache : UObject
    {
        public List<TCachedData> CachedData;

        [Location("void UPCGLandscapeCache::Serialize(FArchive& Archive)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref CachedData);
            return this;
        }

        public class TCachedData : ITransferable
        {
            public TTuple<FGuid, FIntPoint> LandscapeName;
            public FPCGLandscapeCacheEntry Entry;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref LandscapeName);
                transfer.Move(ref Entry);
                return this;
            }
        }
    }

    public class FPCGLandscapeCacheEntry : ITransferable
    {
        public FVector PointHalfSize;
        public int32 Stride;
        public List<FName> LayerDataNames;
        public FByteBulkData BulkData;

        [Location("void FPCGLandscapeCacheEntry::Serialize(FArchive& Archive, UObject* Owner, int32 Index, EPCGLandscapeCacheSerializationContents SerializeContents)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref PointHalfSize);
            transfer.Move(ref Stride);
            transfer.Move(ref LayerDataNames);
            transfer.Move(ref BulkData);
            return this;
        }
    }
}