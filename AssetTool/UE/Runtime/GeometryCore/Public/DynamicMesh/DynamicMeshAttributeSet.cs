namespace AssetTool.Geometry
{
    using FDynamicMeshBoneNameAttribute = TDynamicBoneAttributeBase<FDynamicMesh3, FName>;
    using FDynamicMeshBoneParentIndexAttribute = TDynamicBoneAttributeBase<FDynamicMesh3, int32>;
    using FDynamicMeshBoneColorAttribute = TDynamicBoneAttributeBase<FDynamicMesh3, FVector4f>;
    using FDynamicMeshBonePoseAttribute = TDynamicBoneAttributeBase<FDynamicMesh3, FTransform>;

    public class FDynamicMeshAttributeSet : ITransferible<FCompactMaps, bool>
    {
        public List<TDynamicMeshVectorOverlayFloat2> UVLayers;
        public List<TDynamicMeshVectorOverlayFloat3> NormalLayers;
        public List<TDynamicMeshTriangleAttributeInt32> PolygroupLayers;
        public List<FDynamicMeshUVOverlayFloat1> WeightLayers;
        public int32 NumColorLayers;
        public FDynamicMeshUVOverlayFloat4 ColorLayer;
        public FBool bHasMaterialID;
        public TDynamicMeshTriangleAttributeInt32 MaterialIDAttrib;
        public Dictionary<TTuple<FString, FBool>, TDynamicAttributeBase> SkinWeightAttributes;
        public FBool bHasBones;
        public FDynamicMeshBoneNameAttribute BoneNameAttrib;
        public FDynamicMeshBoneParentIndexAttribute BoneParentIndexAttrib;
        public FDynamicMeshBonePoseAttribute BonePoseAttrib;
        public FDynamicMeshBoneColorAttribute BoneColorAttrib;

        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        [Location("void FDynamicMeshAttributeSet::Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public ITransferible Move(Transfer transfer, FCompactMaps CompactMaps, bool bUseCompression)
        {
            bool bUseLegacySerialization = !transfer.Supports.DynamicMeshCompactedSerialization;
            if (bUseLegacySerialization)
            {
                transfer.Move(ref UVLayers);
                transfer.Move(ref NormalLayers);
                transfer.Move(ref PolygroupLayers);
            }
            else
            {
                transfer.Move(ref bUseCompression);

                SerializeLayers(transfer, ref UVLayers, CompactMaps, bUseCompression);
                SerializeLayers(transfer, ref NormalLayers, CompactMaps, bUseCompression);
                SerializeLayers(transfer, ref PolygroupLayers, CompactMaps, bUseCompression);

                bool bSerializeWeightLayers = transfer.Supports.DynamicMeshAttributesWeightMapsAndNames;
                if (bSerializeWeightLayers)
                {
                    SerializeLayers(transfer, ref WeightLayers, CompactMaps, bUseCompression);
                }
            }
            transfer.Move(ref NumColorLayers);
            if (NumColorLayers > 0)
            {
                transfer.Move(ref ColorLayer, CompactMaps, bUseCompression);
            }
            transfer.Move(ref bHasMaterialID);
            if (bHasMaterialID)
            {
                transfer.Move(ref MaterialIDAttrib, CompactMaps, bUseCompression);
            }
            if (!bUseLegacySerialization)
            {
                transfer.Move(ref SkinWeightAttributes);
            }
            bool bSerializeBones = transfer.Supports.DynamicMeshAttributesSerializeBones;
            if (bSerializeBones)
            {
                transfer.Move(ref bHasBones);
                if (bHasBones)
                {
                    transfer.Move(ref BoneNameAttrib);
                    transfer.Move(ref BoneParentIndexAttrib);
                    transfer.Move(ref BonePoseAttrib);
                    transfer.Move(ref BoneColorAttrib);
                }
            }
            return this;
        }

        [Location("void SerializeLayers(TIndirectArray<LayerType>& Layers, FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public void SerializeLayers<T>(Transfer transfer, ref List<T> layers, FCompactMaps compactMaps, bool bUseCompression) where T : ITransferible<FCompactMaps, bool>, new()
        {
            transfer.Move(ref layers, compactMaps, bUseCompression);
        }
    }
}
