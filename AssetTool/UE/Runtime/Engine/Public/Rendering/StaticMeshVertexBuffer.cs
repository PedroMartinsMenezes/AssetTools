namespace AssetTool
{
    public class FStaticMeshVertexBuffer : FRenderResource, ITransferible
    {
        public FStripDataFlags StripFlags;
        public uint32 NumTexCoords;
        public uint32 NumVertices;
        public bool bUseFullPrecisionUVs;
        public bool bUseHighPrecisionTangentBasis;
        public FStaticMeshVertexDataInterface TangentsData;
        public FStaticMeshVertexDataInterface TexcoordData;

        [Location("void FStaticMeshVertexBuffer::Serialize(FArchive& Ar, bool bNeedsCPUAccess)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);
            SerializeMetaData(transfer);
            AllocateData();
            if (!StripFlags.IsAudioVisualDataStripped())
            {
                TangentsData.Move(transfer);
                TexcoordData.Move(transfer);
            }
            return this;
        }

        private void AllocateData()
        {
            TangentsData ??= bUseHighPrecisionTangentBasis ? new TStaticMeshVertexData<TDouble>() : new TStaticMeshVertexData<TFloat>();
            TexcoordData ??= bUseFullPrecisionUVs ? new TStaticMeshVertexData<TDouble>() : new TStaticMeshVertexData<TFloat>();
        }

        private void SerializeMetaData(Transfer transfer)
        {
            transfer.Move(ref NumTexCoords);
            transfer.Move(ref NumVertices);
            transfer.Move(ref bUseFullPrecisionUVs);
            transfer.Move(ref bUseHighPrecisionTangentBasis);
        }
    }
}
