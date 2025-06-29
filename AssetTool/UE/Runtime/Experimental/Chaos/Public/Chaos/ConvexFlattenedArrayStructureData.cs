namespace AssetTool.Chaos
{
    using FConvexFlattenedArrayStructureDataS32 = TConvexFlattenedArrayStructureData<TInt32, TInt32>;
    using FConvexFlattenedArrayStructureDataU8 = TConvexFlattenedArrayStructureData<TUInt8, TUInt16>;

    [Location("https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Runtime/Experimental/Chaos/Public/Chaos/ConvexFlattenedArrayStructureData.h")]
    public class FLegacyConvexStructureDataLoader : ITransferible
    {
        public List<List<TInt32>> OldPlaneVertices;
        public TListOfList<TInt32> OldVertexPlanes;
        public EIndexType OldIndexType;
        public FConvexFlattenedArrayStructureDataS32 OldDataS32;
        public FConvexFlattenedArrayStructureDataU8 OldDataU8;

        [Location("static void Load(FArchive& Ar, TArray<TArray<int32>>& OutPlaneVertices, int32& OutNumVertices)")]
        public ITransferible Move(Transfer transfer)
        {
            bool bUseVariableSizeStructureDataUE4 = transfer.Supports.VariableConvexStructureData;
            bool bUseVariableSizeStructureDataFN = transfer.Supports.ChaosConvexVariableStructureDataAndVerticesArray;
            bool bUseVariableSizeStructureData = bUseVariableSizeStructureDataUE4 || bUseVariableSizeStructureDataFN;
            if (!bUseVariableSizeStructureData)
                LoadFixedSizeRaggedArrays(transfer);
            else
                LoadVariableSizePackedArrays(transfer);
            return this;
        }

        private void LoadFixedSizeRaggedArrays(Transfer transfer)
        {
            transfer.Move(ref OldPlaneVertices);
            transfer.Move(ref OldVertexPlanes);
        }

        private void LoadVariableSizePackedArrays(Transfer transfer)
        {
            transfer.MoveEnum(ref OldIndexType);
            if (OldIndexType == EIndexType.S32)
            {
                transfer.Move(ref OldDataS32);
            }
            else if (OldIndexType == EIndexType.U8)
            {
                transfer.Move(ref OldDataU8);
            }
        }

        public enum EIndexType : int8
        {
            None,
            S32,
            U8,
        }
    }

    public class FConvexFlattenedArrayStructureData
    {
    }

    public class TConvexFlattenedArrayStructureData<FIndex, FOffsetIndex> : FConvexFlattenedArrayStructureData, ITransferible where FIndex : ITransferible, new() where FOffsetIndex : ITransferible, new()
    {
        public List<TTuple<FOffsetIndex, FIndex>> PlaneVerticesOffsetCount;
        public List<TTuple<FOffsetIndex, FIndex>> VertexPlanesOffsetCount;
        public List<FIndex> PlaneVertices;
        public List<FIndex> VertexPlanes;

        [Location("void Serialize(FArchive& Ar) at 165")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref PlaneVerticesOffsetCount);
            transfer.Move(ref VertexPlanesOffsetCount);
            transfer.Move(ref PlaneVertices);
            transfer.Move(ref VertexPlanes);
            return this;
        }
    }
}
