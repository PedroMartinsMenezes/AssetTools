namespace AssetTool
{
    [JsonAsset("InstancedStaticMeshComponent")]
    public class UInstancedStaticMeshComponent : UStaticMeshComponent
    {
        public FBool bCooked;
        public List<FInstancedStaticMeshInstanceData_DEPRECATED> DeprecatedData;
        public Int32 PerInstanceSMDataElementSize;
        public List<FInstancedStaticMeshInstanceData> PerInstanceSMData;
        public Int32 PerInstanceSMCustomDataElementSize;
        public List<TFloat> PerInstanceSMCustomData;
        public UInt64 RenderDataSizeBytes;
        public FStaticMeshInstanceData InstanceDataBuffers;

        [Location("void UInstancedStaticMeshComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.SerializeInstancedStaticMeshRenderData)
            {
                transfer.Move(ref bCooked);
            }
            if (!Supports.InstancedStaticMeshLightmapSerialization)
            {
                transfer.Move(ref DeprecatedData);
            }
            else
            {
                BulkSerialize(transfer, ref PerInstanceSMData);
            }
            if (Supports.PerInstanceCustomData)
            {
                transfer.Move(ref PerInstanceSMCustomData, ref PerInstanceSMCustomDataElementSize);
            }
            if (bCooked && Supports.SerializeInstancedStaticMeshRenderData)
            {
                SerializeRenderData(transfer);
            }
            return this;
        }

        private void BulkSerialize(Transfer transfer, ref List<FInstancedStaticMeshInstanceData> perInstanceSMData)
        {
            bool bForcePerElementSerialization = !Supports.LARGE_WORLD_COORDINATES;
            if (bForcePerElementSerialization)
            {
                perInstanceSMData ??= [];
                transfer.Move(ref PerInstanceSMData);
            }
            else
            {
                transfer.Move(ref PerInstanceSMData, ref PerInstanceSMDataElementSize);
            }
        }

        [Location("void UInstancedStaticMeshComponent::SerializeRenderData(FArchive& Ar)")]
        private void SerializeRenderData(Transfer transfer)
        {
            transfer.Move(ref RenderDataSizeBytes);
            if (RenderDataSizeBytes > 0)
            {
                transfer.Move(ref InstanceDataBuffers);
            }
        }
    }

    public class FInstancedStaticMeshInstanceData_DEPRECATED : ITransferible
    {
        public FMatrix44f Transform;
        public FVector2f LightmapUVBias;
        public FVector2f ShadowmapUVBias;

        public ITransferible Move(Transfer transfer)
        {
            Transform.Move(transfer);
            transfer.Move(ref LightmapUVBias);
            transfer.Move(ref ShadowmapUVBias);
            return this;
        }
    }

    public class FInstancedStaticMeshInstanceData : ITransferible
    {
        public FMatrix Transform;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Transform);
            return this;
        }
    }
}