namespace AssetTool
{
    public class FPositionVertexBuffer : FVertexBuffer, ITransferable
    {
        public uint32 Stride;
        public uint32 NumVertices;
        public FPositionVertexData<FPositionVertex> VertexData;

        [Location("void FPositionVertexBuffer::Serialize( FArchive& Ar, bool bInNeedsCPUAccess )")]
        public ITransferable Move(Transfer transfer)
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

    public class FPositionVertexData<T> : TStaticMeshVertexData<T> where T : ITransferable, new()
    {
    }

    public class FPositionVertex : ITransferable
    {
        public FVector3f Position;

        [Location("friend FArchive& operator<<(FArchive& Ar, FPositionVertex& V)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Position);
            return this;
        }
    }
}
