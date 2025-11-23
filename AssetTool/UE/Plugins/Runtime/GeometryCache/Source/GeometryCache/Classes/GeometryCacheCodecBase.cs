namespace AssetTool
{
    public class FStreamedGeometryCacheChunk : ITransferable
    {
        public FByteBulkData BulkData;
        public Int32 DataSize;
        public float FirstFrame;
        public float LastFrame;

        [Location("void FStreamedGeometryCacheChunk::Serialize(FArchive& Ar, UObject* Owner, int32 ChunkIndex)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref BulkData);
            transfer.Move(ref DataSize);
            transfer.Move(ref FirstFrame);
            transfer.Move(ref LastFrame);
            return this;
        }
    }
}