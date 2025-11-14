namespace AssetTool.Chaos
{
    using FConvexStructureDataLarge = TConvexHalfEdgeStructureData<TInt32>;
    using FConvexStructureDataMedium = TConvexHalfEdgeStructureData<TInt16>;
    using FConvexStructureDataSmall = TConvexHalfEdgeStructureData<TUInt8>;

    [Location("https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Runtime/Experimental/Chaos/Public/Chaos/ConvexStructureData.h")]
    public class FConvexStructureData : ITransferable
    {
        public EIndexType IndexType;
        public TListOfList<TInt32> OldPlaneVertices;
        public FConvexStructureDataLarge DataL;
        public FConvexStructureDataMedium DataM;
        public FConvexStructureDataSmall DataS;

        [Location("void Serialize(FArchive& Ar) at 253")]
        public ITransferable Move(Transfer transfer)
        {
            bool bUseHalfEdgeStructureData = transfer.Supports.ChaosConvexUsesHalfEdges;
            if (!bUseHalfEdgeStructureData)
            {
                LoadLegacyData(transfer);
                return this;
            }
            transfer.MoveEnum(ref IndexType);
            NonConstDataOp(transfer);
            return this;
        }

        private void NonConstDataOp(Transfer transfer)
        {
            switch (IndexType)
            {
                case EIndexType.Small:
                    transfer.Move(ref DataS);
                    break;
                case EIndexType.Medium:
                    transfer.Move(ref DataM);
                    break;
                case EIndexType.Large:
                    transfer.Move(ref DataL);
                    break;
            }
        }

        public void LoadLegacyData(Transfer transfer)
        {
            transfer.Move(ref OldPlaneVertices);
        }

        public enum EIndexType : int8
        {
            None,
            Small,
            Medium,
            Large,
        }
    }
}
