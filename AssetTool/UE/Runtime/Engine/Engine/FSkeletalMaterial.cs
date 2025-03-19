namespace AssetTool
{
    public class FSkeletalMaterial : ITransferible
    {
        public UInt32 MaterialInterface;
        public FName MaterialSlotName;
        public FBool bSerializeImportedMaterialSlotName;
        public FName ImportedMaterialSlotName;
        public FBool bEnableShadowCasting_DEPRECATED;
        public FBool bRecomputeTangent_DEPRECATED;
        public FMeshUVChannelInfo UVChannelData;

        [Location("FArchive& operator<<(FArchive& Ar, FSkeletalMaterial& Elem)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref MaterialInterface);
            if (Supports.RefactorMeshEditorMaterials)
            {
                transfer.Move(ref MaterialSlotName);
                if (Supports.SkeletalMaterialEditorDataStripping)
                {
                    transfer.Move(ref bSerializeImportedMaterialSlotName);
                }
                if (bSerializeImportedMaterialSlotName)
                {
                    transfer.Move(ref ImportedMaterialSlotName);
                }
            }
            else
            {
                if (Supports.VER_UE4_MOVE_SKELETALMESH_SHADOWCASTING)
                {
                    transfer.Move(ref bEnableShadowCasting_DEPRECATED);
                }
                if (Supports.RuntimeRecomputeTangent)
                {
                    transfer.Move(ref bRecomputeTangent_DEPRECATED);
                }
            }
            if (Supports.TextureStreamingMeshUVChannelData)
            {
                UVChannelData ??= new();
                UVChannelData.Move(transfer);
            }
            return this;
        }
    }
}
