namespace AssetTool
{
    [JsonAsset("InstancedStaticMeshComponent")]
    public class UInstancedStaticMeshComponent : UStaticMeshComponent
    {
        public FBool bCooked;
        public FBool bHasSkipSerializationPropertiesData;
        public TBulkList<FInstancedStaticMeshInstanceData> TempPerInstanceSMData;
        public TBulkList<TFloat> TempPerInstanceSMCustomData;
        public TBulkList<FInstancedStaticMeshInstanceData_DEPRECATED> DeprecatedData;
        public UInt64 RenderDataSizeBytes;
        public FStaticMeshInstanceData InstanceDataBuffers;

        [Location("void UInstancedStaticMeshComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            if (transfer.Supports.FFortniteMainBranchObjectVersion_SerializeInstancedStaticMeshRenderData || transfer.Supports.FEditorObjectVersion_SerializeInstancedStaticMeshRenderData)
                transfer.Move(ref bCooked);

            if (!transfer.Supports.ISMComponentEditableWhenInheritedSkipSerialization)
                bHasSkipSerializationPropertiesData = true;
            else
                transfer.Move(ref bHasSkipSerializationPropertiesData);

            if (!transfer.Supports.InstancedStaticMeshLightmapSerialization)
            {
                transfer.Move(ref DeprecatedData);
            }
            else
            {
                if (bHasSkipSerializationPropertiesData)
                {
                    transfer.Move(ref TempPerInstanceSMData);
                    if (transfer.Supports.PerInstanceCustomData)
                    {
                        transfer.Move(ref TempPerInstanceSMCustomData);
                    }
                }
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

    public class FInstancedStaticMeshInstanceData_DEPRECATED : ITransferable
    {
        public FMatrix44f Transform;
        public FVector2f LightmapUVBias;
        public FVector2f ShadowmapUVBias;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Transform);
            transfer.Move(ref LightmapUVBias);
            transfer.Move(ref ShadowmapUVBias);
            return this;
        }
    }

    public class FInstancedStaticMeshInstanceData : ITransferable
    {
        public FMatrix Transform;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Transform);
            return this;
        }
    }
}