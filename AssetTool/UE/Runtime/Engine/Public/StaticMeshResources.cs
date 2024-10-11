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
            if (Supports.PerInstanceCustomData)
            {
                transfer.Move(ref NumCustomDataFloats);
            }
            transfer.Move(ref InstanceOriginData);
            transfer.Move(ref InstanceLightmapData);
            transfer.Move(ref InstanceTransformData);
            if (Supports.PerInstanceCustomData)
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
}
