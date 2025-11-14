namespace AssetTool
{
    public class FSkeletalMeshVertexClothBuffer : FVertexBuffer, ITransferable
    {
        public FStripDataFlags StripFlags;
        public FSkeletalMeshVertexDataInterface VertexData;

        [Location("FArchive& operator<<(FArchive& Ar, FSkeletalMeshVertexClothBuffer& VertexBuffer)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);

            AllocateData();

            return this;
        }

        private void AllocateData()
        {
            VertexData ??= new TSkeletalMeshVertexData<FMeshToMeshVertData>();
        }
    }
}
