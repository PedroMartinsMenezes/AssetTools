namespace AssetTool
{
    [JsonAsset("InstancedStaticMeshComponent")]
    public class UInstancedStaticMeshComponent : UStaticMeshComponent
    {
        public FBool bCooked;
        public FBool bHasSkipSerializationPropertiesData;
        public List<FInstancedStaticMeshInstanceData_DEPRECATED> DeprecatedData;
        public TBulkList<FInstancedStaticMeshInstanceData> PerInstanceSMData;
        public TBulkList<TFloat> PerInstanceSMCustomData;
        public UInt64 RenderDataSizeBytes;
        public FStaticMeshInstanceData InstanceDataBuffers;

        [Location("void UInstancedStaticMeshComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.FFortniteMainBranchObjectVersion_SerializeInstancedStaticMeshRenderData || transfer.Supports.FEditorObjectVersion_SerializeInstancedStaticMeshRenderData)
            {
                transfer.Move(ref bCooked);
            }
            if (transfer.Supports.ISMComponentEditableWhenInheritedSkipSerialization)
            {
                transfer.Move(ref bHasSkipSerializationPropertiesData);
            }
            if (!transfer.Supports.InstancedStaticMeshLightmapSerialization)
            {
                transfer.Move(ref DeprecatedData);
            }
            else
            {
                transfer.Move(ref PerInstanceSMData);
            }
            if (transfer.Supports.PerInstanceCustomData)
            {
                transfer.Move(ref PerInstanceSMCustomData);
            }
            if (bCooked && (transfer.Supports.FFortniteMainBranchObjectVersion_SerializeInstancedStaticMeshRenderData || transfer.Supports.FEditorObjectVersion_SerializeInstancedStaticMeshRenderData))
            {
                SerializeRenderData(transfer);
            }
            return this;
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
            transfer.Move(ref Transform);
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