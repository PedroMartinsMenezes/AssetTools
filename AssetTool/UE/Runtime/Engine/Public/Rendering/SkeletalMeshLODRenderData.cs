namespace AssetTool
{
    public class FSkelMeshRenderSection : ITransferable
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
        public ITransferable Move(Transfer transfer)
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

    public class FSkeletalMeshLODRenderData : ITransferable
    {
        public FStripDataFlags StripFlags;
        public bool bIsLODCookedOut;
        public bool bInlined;
        public List<FBoneIndexType> RequiredBones;

        [Location("void FSkeletalMeshLODRenderData::Serialize(FArchive& Ar, UObject* Owner, int32 Idx)")]
        public ITransferable Move(Transfer transfer)
        {
            bool bUsingCookedEditorData = false;
            transfer.Move(ref StripFlags);
            transfer.Move(ref bIsLODCookedOut);
            transfer.Move(ref bInlined);
            transfer.Move(ref RequiredBones);
            if (!StripFlags.IsAudioVisualDataStripped())
            {
                throw new NotImplementedException();
                //Ar << RenderSections;
                //Ar << ActiveBoneIndices;
                //Ar << BuffersSize;
                if (bInlined)
                {
                    SerializeStreamedData(transfer);
                }
                else if (transfer.GlobalObjects.IsFilterEditorOnly())
                {
                    bool bDiscardBulkData = false;
                    //StreamingBulkData.Serialize(Ar, Owner, Idx, false);
                    int BulkDataSize = 0; // StreamingBulkData.GetBulkDataSize();
                    if (BulkDataSize > 0 && bUsingCookedEditorData)
                    {
                        SerializeStreamedData(transfer);
                    }

                    if (!bDiscardBulkData)
                    {
                        SerializeAvailabilityInfo(transfer);
                    }
                }
            }
            return this;
        }

        private void SerializeAvailabilityInfo(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        private void SerializeStreamedData(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
