namespace AssetTool
{
    public class FDuplicatedVerticesBuffer : ITransferable
    {
        public TSkeletalMeshVertexData<TUInt32> DupVertData;
        public TSkeletalMeshVertexData<FIndexLengthPair> DupVertIndexData;

        [Location("friend FArchive& operator<<(FArchive& Ar, FDuplicatedVerticesBuffer& Data)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref DupVertData);
            transfer.Move(ref DupVertIndexData);
            return this;
        }
    }

    public class FIndexLengthPair : ITransferable
    {
        public uint32 Length;
        public uint32 Index;

        [Location("operator<<(FArchive& Ar, FIndexLengthPair& V)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Length);
            transfer.Move(ref Index);
            return this;
        }
    }
}
