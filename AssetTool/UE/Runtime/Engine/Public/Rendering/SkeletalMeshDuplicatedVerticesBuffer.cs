namespace AssetTool
{
    public class FDuplicatedVerticesBuffer : ITransferible
    {
        public TSkeletalMeshVertexData<TUInt32> DupVertData;
        public TSkeletalMeshVertexData<FIndexLengthPair> DupVertIndexData;

        [Location("friend FArchive& operator<<(FArchive& Ar, FDuplicatedVerticesBuffer& Data)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref DupVertData);
            transfer.Move(ref DupVertIndexData);
            return this;
        }
    }

    public class FIndexLengthPair : ITransferible
    {
        public uint32 Length;
        public uint32 Index;

        [Location("operator<<(FArchive& Ar, FIndexLengthPair& V)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Length);
            transfer.Move(ref Index);
            return this;
        }
    }
}
