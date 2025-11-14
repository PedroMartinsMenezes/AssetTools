namespace AssetTool
{
    public class FColorVertexBuffer : FVertexBuffer, ITransferable
    {
        public FStripDataFlags StripFlags;
        public uint32 Stride;
        public uint32 NumVertices;
        public FColorVertexData VertexData;

        [Location("void FColorVertexBuffer::Serialize( FArchive& Ar, bool bNeedsCPUAccess )")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);
            SerializeMetaData(transfer);
            if (NumVertices > 0)
            {
                AllocateData();
            }
            if (!StripFlags.IsAudioVisualDataStripped())
            {
                VertexData.Move(transfer);
            }
            return this;
        }

        private void AllocateData()
        {
            VertexData ??= new();
        }

        private void SerializeMetaData(Transfer transfer)
        {
            transfer.Move(ref Stride);
            transfer.Move(ref NumVertices);
        }
    }

    public class FColorVertexData : TStaticMeshVertexData<FColor>, ITransferable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
