namespace AssetTool
{
    public class FGeometryCollectionSection : ITransferible
    {
        public int32 MaterialID;
        public int32 FirstIndex;
        public int32 NumTriangles;
        public int32 MinVertexIndex;
        public int32 MaxVertexIndex;

        [Location("friend FArchive& operator<<(FArchive& Ar, FGeometryCollectionSection& Section)")]
        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref MaterialID);
            transfer.Move(ref FirstIndex);
            transfer.Move(ref NumTriangles);
            transfer.Move(ref MinVertexIndex);
            transfer.Move(ref MaxVertexIndex);
            return this;
        }
    }
}