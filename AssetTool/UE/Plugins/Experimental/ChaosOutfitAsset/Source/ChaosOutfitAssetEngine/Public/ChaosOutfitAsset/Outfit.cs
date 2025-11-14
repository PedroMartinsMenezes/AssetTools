namespace AssetTool
{
    [JsonAsset("ChaosOutfit")]
    public class UChaosOutfit : UObject
    {
        public FReferenceSkeleton ReferenceSkeleton;
        public FRenderData RenderData;

        [Location("void UChaosOutfit::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref ReferenceSkeleton);
            transfer.Move(ref RenderData);
            return this;
        }
    }

    public class FRenderData : ITransferable
    {
        public List<FLODRenderData> LODRenderData;
        public uint8 NumInlinedLODs;
        public uint8 NumNonOptionalLODs;
        public bool bSupportRayTracing;

        [Location("friend FArchive& operator<<(FArchive& Ar, UChaosOutfit::FRenderData& InRenderData)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref LODRenderData);
            transfer.Move(ref NumInlinedLODs);
            transfer.Move(ref NumNonOptionalLODs);
            transfer.Move(ref bSupportRayTracing);
            return this;
        }
    }

    public class FLODRenderData : ITransferable
    {
        public List<FSkelMeshRenderSection> RenderSections;
        public FMultiSizeIndexContainer MultiSizeIndexContainer;
        public FStaticMeshVertexBuffers StaticVertexBuffers = new();
        public FSkinWeightVertexBuffer SkinWeightVertexBuffer;
        public FSkeletalMeshVertexClothBuffer ClothVertexBuffer;
        public uint16[] ActiveBoneIndices;
        public uint16[] RequiredBones;
        public FDummyHalfEdgeBuffer HalfEdgeBuffer;

        [Location("operator<<(FArchive& Ar, UChaosOutfit::FLODRenderData& LODRenderData)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref RenderSections);
            transfer.Move(ref MultiSizeIndexContainer);
            transfer.Move(ref StaticVertexBuffers.PositionVertexBuffer);
            transfer.Move(ref StaticVertexBuffers.StaticMeshVertexBuffer);
            transfer.Move(ref SkinWeightVertexBuffer);
            if (HasClothData())
            {
                transfer.Move(ref ClothVertexBuffer);
            }
            transfer.Move(ref ActiveBoneIndices);
            transfer.Move(ref RequiredBones);
            transfer.Move(ref HalfEdgeBuffer);
            return this;
        }

        public bool HasClothData()
        {
            for (int32 SectionIdx = 0; SectionIdx < RenderSections.Count; SectionIdx++)
            {
                if (RenderSections[SectionIdx].HasClothingData())
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class FDummyHalfEdgeBuffer : ITransferable
    {
        public bool bHasHalfEdges;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bHasHalfEdges);
            return this;
        }
    }

    [TransferableStruct("ChaosOutfitPiece")]
    public class FChaosOutfitPiece : ITransferable
    {
        public UScriptStruct ScriptStruct1 = new();
        public UScriptStruct ScriptStruct2 = new();
        public List<FManagedArrayCollection> NewCollection;

        [Location("bool FChaosOutfitPiece::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            ScriptStruct1.SerializeTaggedProperties(transfer);
            ScriptStruct2.SerializeTaggedProperties(transfer);
            transfer.Move(ref NewCollection);
            return this;
        }
    }
}