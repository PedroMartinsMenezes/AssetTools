namespace AssetTool
{
    [JsonAsset("GeometryCacheTrackStreamable")]
    public class UGeometryCacheTrackStreamable : UGeometryCacheTrack
    {
        public List<FStreamedGeometryCacheChunk> Chunks;
        public List<FGeometryCacheTrackStreamableSampleInfo> Samples;
        public List<FVisibilitySample> VisibilitySamples;

        [Location("void UGeometryCacheTrackStreamable::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);//7241
            transfer.Move(ref Chunks);
            transfer.Move(ref Samples);
            transfer.Move(ref VisibilitySamples);
            return this;
        }
    }

    public class FGeometryCacheTrackStreamableSampleInfo : FGeometryCacheTrackSampleInfo, ITransferible
    {
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref SampleTime);
            transfer.Move(ref BoundingBox);
            transfer.Move(ref NumVertices);
            transfer.Move(ref NumIndices);
            return this;
        }
    }
}