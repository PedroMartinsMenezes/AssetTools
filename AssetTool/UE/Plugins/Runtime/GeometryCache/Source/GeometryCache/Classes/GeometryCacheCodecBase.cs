namespace AssetTool
{
    [JsonAsset("GeometryCacheCodecBase")]
    public class UGeometryCacheCodecBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FStreamedGeometryCacheChunk : ITransferible
    {
        public FByteBulkData BulkData;
        public Int32 DataSize;
        public float FirstFrame;
        public float LastFrame;

        [Location("void FStreamedGeometryCacheChunk::Serialize(FArchive& Ar, UObject* Owner, int32 ChunkIndex)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref BulkData);
            transfer.Move(ref DataSize);
            transfer.Move(ref FirstFrame);
            transfer.Move(ref LastFrame);
            return this;
        }
    }
}