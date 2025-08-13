namespace AssetTool
{
    public class FSkelMeshRenderSection : ITransferible
    {
        public List<List<FMeshToMeshVertData>> ClothMappingDataLODs;
        public FStripDataFlags StripFlags;
        public uint16 MaterialIndex;
        public uint32 BaseIndex;
        public uint32 NumTriangles;
        public bool bRecomputeTangent;
        public ESkinVertexColorChannel RecomputeTangentsVertexMaskChannel;
        public bool bCastShadow;
        public bool bVisibleInRayTracing;
        public uint32 BaseVertexIndex;
        public UInt16[] BoneMap;
        public uint32 NumVertices;
        public int32 MaxBoneInfluences;
        public int16 CorrespondClothAssetIndex;
        public FClothingSectionData ClothingData;
        public FDuplicatedVerticesBuffer DuplicatedVerticesBuffer;
        public bool bDisabled;

        [Location("FArchive& operator<<(FArchive& Ar, FSkelMeshRenderSection& S)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);
            transfer.Move(ref MaterialIndex);
            transfer.Move(ref BaseIndex);
            transfer.Move(ref NumTriangles);
            transfer.Move(ref bRecomputeTangent);
            if (transfer.Supports.RecomputeTangentVertexColorMask)
            {
                transfer.MoveEnum(ref RecomputeTangentsVertexMaskChannel);
            }
            transfer.Move(ref bCastShadow);
            if (transfer.Supports.SkelMeshSectionVisibleInRayTracingFlagAdded)
            {
                transfer.Move(ref bVisibleInRayTracing);
            }
            transfer.Move(ref BaseVertexIndex);
            if (!transfer.Supports.AddClothMappingLODBias)
            {
                ClothMappingDataLODs ??= [new()];
                transfer.Move(ref ClothMappingDataLODs, 0);
            }
            else
            {
                transfer.Move(ref ClothMappingDataLODs);
            }
            transfer.Move(ref BoneMap);
            transfer.Move(ref NumVertices);
            transfer.Move(ref MaxBoneInfluences);
            transfer.Move(ref CorrespondClothAssetIndex);
            transfer.Move(ref ClothingData);
            if (!StripFlags.IsClassDataStripped(1))
            {
                transfer.Move(ref DuplicatedVerticesBuffer);
            }
            transfer.Move(ref bDisabled);
            return this;
        }

        public bool HasClothingData()
        {
            return ClothMappingDataLODs.Count > 0 && ClothMappingDataLODs[0].Count > 0;
        }
    }
}
