using System.ComponentModel;

namespace AssetTool
{
    public class FStaticMeshInstanceData : ITransferible
    {
        public FBool bUseHalfFloat;
        public Int32 NumInstances;
        public Int32 NumCustomDataFloats;
        public TStaticMeshVertexData<FVector4f> InstanceOriginData;
        public TStaticMeshVertexData<FInstanceLightMapVector> InstanceLightmapData;
        public TStaticMeshVertexData<TFloat> InstanceTransformData;
        public TStaticMeshVertexData<TFloat> InstanceCustomData;

        [Location("void FStaticMeshInstanceData::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bUseHalfFloat);
            transfer.Move(ref NumInstances);
            if (transfer.Supports.PerInstanceCustomData)
            {
                transfer.Move(ref NumCustomDataFloats);
            }
            transfer.Move(ref InstanceOriginData);
            transfer.Move(ref InstanceLightmapData);
            transfer.Move(ref InstanceTransformData);
            if (transfer.Supports.PerInstanceCustomData)
            {
                transfer.Move(ref InstanceCustomData);
            }
            return this;
        }
    }

    public class FInstanceLightMapVector : ITransferible
    {
        public Int16[] InstanceLightmapAndShadowMapUVBias = [0, 0, 0, 0];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref InstanceLightmapAndShadowMapUVBias, 4);
            return this;
        }
    }

    public class FStaticMeshRenderData : ITransferible
    {
        const int MAX_STATIC_TEXCOORDS = 8;
        const int MAX_STATIC_MESH_LODS = 8;
        public FBool bCooked;
        public Int32[] MaterialIndexToImportIndex;
        public UInt64 EstimatedNaniteTotalCompressedSize;
        public UInt64 EstimatedNaniteStreamingCompressedSize;
        public byte NumInlinedLODs;
        public FStripDataFlags StripFlags;
        public FStripDataFlags StripFlags2;

        [Description("TPimplPtr<Nanite::FResources>")]
        public UInt32 NaniteResourcesPtr;

        [Description("using FStaticMeshLODResourcesArray = TIndirectArray<FStaticMeshLODResources>;")]
        public List<UInt32> LODResourcesPointers;
        public List<FBool> IsValidCardRepresentationData;
        public List<FBool> IsValidDistanceFieldData;
        public List<FStaticMeshLODResources> LODResources;

        public FBoxSphereBounds Bounds;
        public FBool bLODsShareStaticLighting;

        public float[] DummyFactor;
        public float[] ScreenSize;

        [Location("void FStaticMeshRenderData::Serialize(FArchive& Ar, UStaticMesh* Owner, bool bCooked)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!bCooked)
            {
                transfer.Move(ref MaterialIndexToImportIndex);
                transfer.Move(ref EstimatedNaniteTotalCompressedSize);
                transfer.Move(ref EstimatedNaniteStreamingCompressedSize);
            }
            transfer.Move(ref LODResourcesPointers);
            transfer.Move(ref NumInlinedLODs);
            transfer.Move(ref NaniteResourcesPtr);
            if (bCooked)
            {
                SerializeInlineDataRepresentations(transfer);
                StripFlags2 ??= new();
                StripFlags2.Move(transfer);
                if (!StripFlags.IsDataStrippedForServer() && !StripFlags.IsClassDataStripped(1))
                {
                    for (int ResourceIndex = 0; ResourceIndex < LODResources.Count; ResourceIndex++)
                    {
                        IsValidDistanceFieldData[ResourceIndex].Move(transfer);
                        if (IsValidDistanceFieldData[ResourceIndex])
                        {
                            LODResources[ResourceIndex].MoveDistanceFieldData(transfer);
                        }
                    }
                }
            }

            transfer.Move(ref Bounds);
            transfer.Move(ref bLODsShareStaticLighting);

            if (!transfer.Supports.TextureStreamingMeshUVChannelData)
            {
                DummyFactor ??= new float[MAX_STATIC_TEXCOORDS + 1];
                transfer.Move(ref DummyFactor, MAX_STATIC_TEXCOORDS + 1);
            }

            if (bCooked)
            {
                ScreenSize ??= new float[MAX_STATIC_MESH_LODS];
                transfer.Move(ref ScreenSize, MAX_STATIC_MESH_LODS);
            }

            return this;
        }

        private void SerializeInlineDataRepresentations(Transfer transfer)
        {
            StripFlags ??= new();
            StripFlags.Move(transfer);
            if (!StripFlags.IsDataStrippedForServer() && !StripFlags.IsClassDataStripped(2))
            {
                if (LODResourcesPointers.Count > 0)
                {
                    IsValidCardRepresentationData.Resize(transfer, LODResourcesPointers.Count);
                    LODResources.Resize(transfer, LODResourcesPointers.Count);
                }
                for (int ResourceIndex = 0; ResourceIndex < LODResourcesPointers.Count; ResourceIndex++)
                {
                    IsValidCardRepresentationData[ResourceIndex].Move(transfer);
                    if (IsValidCardRepresentationData[ResourceIndex])
                    {
                        LODResources[ResourceIndex].MoveCardRepresentationData(transfer);
                    }
                }
            }
        }
    }

    public class FStaticMeshLODResources
    {
        [Description("FCardRepresentationData* CardRepresentationData")]
        public UInt32 CardRepresentationData;

        [Description("FDistanceFieldVolumeData* DistanceFieldData")]
        public UInt32 DistanceFieldData;

        public void MoveCardRepresentationData(Transfer transfer)
        {
            transfer.Move(ref CardRepresentationData);
        }

        public void MoveDistanceFieldData(Transfer transfer)
        {
            transfer.Move(ref DistanceFieldData);
        }
    }
}
