namespace AssetTool
{
    [JsonAsset("GeometryCacheTrack")]
    public class UGeometryCacheTrack : UObject
    {
        public List<FMatrix> MatrixSamples;
        public List<float> MatrixSampleTimes;
        public UInt32 NumMaterials;

        [Location("void UGeometryCacheTrack::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            if (Supports.GeometryCacheAssetDeprecation)
            {
                base.Move(transfer);
            }
            transfer.Move(ref MatrixSamples);
            transfer.Move(ref MatrixSampleTimes);
            transfer.Move(ref NumMaterials);
            return this;
        }
    }

    public class FGeometryCacheTrackSampleInfo
    {
        public float SampleTime;
        public FBox BoundingBox;
        public int32 NumVertices;
        public int32 NumIndices;
    }

    public class FVisibilitySample : ITransferible
    {
        public TRangeFloat Range;
        public FBool bVisibilityState;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Range);
            transfer.Move(ref bVisibilityState);
            return this;
        }
    }
}