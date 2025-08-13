namespace AssetTool
{
    public class FPositionVertexBuffer : FVertexBuffer, ITransferible
    {
        public uint32 Stride;
        public uint32 NumVertices;
        public FPositionVertexData<FPositionVertex> VertexData;

        [Location("void FPositionVertexBuffer::Serialize( FArchive& Ar, bool bInNeedsCPUAccess )")]
        public ITransferible Move(Transfer transfer)
        {
            SerializeMetaData(transfer);
            transfer.Move(ref VertexData);
            return this;
        }

        private void SerializeMetaData(Transfer transfer)
        {
            transfer.Move(ref Stride);
            transfer.Move(ref NumVertices);
        }
    }

    public class FPositionVertexData<T> : TStaticMeshVertexData<T> where T : ITransferible, new()
    {
    }

    public class FPositionVertex : ITransferible
    {
        public FVector3f Position;

        [Location("friend FArchive& operator<<(FArchive& Ar, FPositionVertex& V)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Position);
            return this;
        }
    }
}
