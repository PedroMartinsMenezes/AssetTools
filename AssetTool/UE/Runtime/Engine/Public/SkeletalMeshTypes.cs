namespace AssetTool
{
    public enum ESkinVertexColorChannel : byte
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Alpha = 3,
        None = Alpha
    }

    public class FMeshToMeshVertData : ITransferible
    {
        public FVector4f PositionBaryCoordsAndDist = new();
        public FVector4f NormalBaryCoordsAndDist = new();
        public FVector4f TangentBaryCoordsAndDist = new();
        public UInt16[] SourceMeshVertIndices = [0, 0, 0, 0];
        public float Weight = 0.0f;
        public UInt32 Discard;
        public UInt32 Padding;

        [Location("FArchive& operator<<(FArchive& Ar, FMeshToMeshVertData& V)")]
        public ITransferible Move(Transfer transfer)
        {
            PositionBaryCoordsAndDist.Move(transfer);
            NormalBaryCoordsAndDist.Move(transfer);
            TangentBaryCoordsAndDist.Move(transfer);
            transfer.Move(ref SourceMeshVertIndices[0]);
            transfer.Move(ref SourceMeshVertIndices[1]);
            transfer.Move(ref SourceMeshVertIndices[2]);
            transfer.Move(ref SourceMeshVertIndices[3]);
            if (!Supports.CustomVer(FReleaseObjectVersion.Enums.WeightFMeshToMeshVertData))
            {
                transfer.Move(ref Discard);
                transfer.Move(ref Padding);
            }
            else
            {
                transfer.Move(ref Weight);
                transfer.Move(ref Padding);
            }
            return this;
        }
    }

    public class FClothingSectionData : ITransferible
    {
        public FGuid AssetGuid;
        public Int32 AssetLodIndex;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref AssetGuid);
            transfer.Move(ref AssetLodIndex);
            return this;
        }
    }
}
