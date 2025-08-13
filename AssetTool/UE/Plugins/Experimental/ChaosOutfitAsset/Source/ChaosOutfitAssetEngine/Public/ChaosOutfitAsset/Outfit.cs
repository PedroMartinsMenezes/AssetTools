namespace AssetTool
{
    [JsonAsset("ChaosOutfit")]
    public class UChaosOutfit : UObject
    {
        public FReferenceSkeleton ReferenceSkeleton;
        public FRenderData RenderData;

        [Location("void UChaosOutfit::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);//7397 -> 11220 OK
            transfer.Move(ref ReferenceSkeleton);//11220 -> 11345 OK
            transfer.Move(ref RenderData);//11345 -> 11355 deveria ser 11478
            return this;
        }
    }

    public class FRenderData : ITransferible
    {
        public List<FLODRenderData> LODRenderData;
        public uint8 NumInlinedLODs;
        public uint8 NumNonOptionalLODs;
        public bool bSupportRayTracing;

        [Location("friend FArchive& operator<<(FArchive& Ar, UChaosOutfit::FRenderData& InRenderData)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref LODRenderData);
            transfer.Move(ref NumInlinedLODs);
            transfer.Move(ref NumNonOptionalLODs);
            transfer.Move(ref bSupportRayTracing);
            return this;
        }
    }

    public class FLODRenderData : ITransferible
    {
        //public FSkinWeightProfilesData SkinWeightProfilesData;
        public List<FSkelMeshRenderSection> RenderSections;
        public FMultiSizeIndexContainer MultiSizeIndexContainer;
        public FStaticMeshVertexBuffers StaticVertexBuffers = new();
        public FSkinWeightVertexBuffer SkinWeightVertexBuffer;
        public FSkeletalMeshVertexClothBuffer ClothVertexBuffer;
        public uint16[] ActiveBoneIndices;
        public uint16[] RequiredBones;
        public FDummyHalfEdgeBuffer HalfEdgeBuffer;

        [Location("operator<<(FArchive& Ar, UChaosOutfit::FLODRenderData& LODRenderData)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref RenderSections);//11349 -> 11353 OK

            transfer.Move(ref MultiSizeIndexContainer);//11353 -> 11362 OK
            transfer.Move(ref StaticVertexBuffers.PositionVertexBuffer);//11362 -> 11378 OK
            transfer.Move(ref StaticVertexBuffers.StaticMeshVertexBuffer);//11378 -> 11412 OK

            transfer.Move(ref SkinWeightVertexBuffer);//11412 -> 11460

            //transfer.Move(ref SkinWeightProfilesData);//11412 -> 11460 NOK 11416
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

    public class FDummyHalfEdgeBuffer : ITransferible
    {
        public bool bHasHalfEdges;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bHasHalfEdges);
            return this;
        }
    }

    [TransferibleStruct("ChaosOutfitPiece")]
    public class FChaosOutfitPiece : ITransferible
    {
        public UScriptStruct ScriptStruct1 = new();
        public UScriptStruct ScriptStruct2 = new();
        public List<FManagedArrayCollection> NewCollection;

        [Location("bool FChaosOutfitPiece::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            ScriptStruct1.SerializeTaggedProperties(transfer);
            ScriptStruct2.SerializeTaggedProperties(transfer);
            transfer.Move(ref NewCollection);
            return this;
        }
    }
}