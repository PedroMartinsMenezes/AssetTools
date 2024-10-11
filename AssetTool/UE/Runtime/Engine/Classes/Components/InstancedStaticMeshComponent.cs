namespace AssetTool.UE.Runtime.Engine.Classes.Components
{
    [JsonAsset("InstancedStaticMeshComponent")]
    public class UInstancedStaticMeshComponent : UStaticMeshComponent
    {
        public FBool bCooked;
        public List<FInstancedStaticMeshInstanceData_DEPRECATED> DeprecatedData;
        public List<FInstancedStaticMeshInstanceData> PerInstanceSMData;
        public List<float> PerInstanceSMCustomData;
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
            if (Supports.InstancedStaticMeshLightmapSerialization)
            {
                transfer.Move(ref DeprecatedData);
            }
            else
            {
                transfer.Move(ref PerInstanceSMData);
            }
            if (Supports.PerInstanceCustomData)
            {
                transfer.Move(ref PerInstanceSMCustomData);
            }
            SerializeRenderData(transfer);
            return this;
        }

        private void SerializeRenderData(Transfer transfer)
        {
            if (bCooked && Supports.SerializeInstancedStaticMeshRenderData)
            {
                transfer.Move(ref RenderDataSizeBytes);
                if (RenderDataSizeBytes > 0)
                {
                    transfer.Move(ref InstanceDataBuffers);
                }
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
