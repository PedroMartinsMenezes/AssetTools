namespace AssetTool
{
    public class FSkeletalMaterial : ITransferable
    {
        public FObjectPtr MaterialInterface;
        public FName MaterialSlotName;
        public FBool bSerializeImportedMaterialSlotName;
        public FName ImportedMaterialSlotName;
        public FBool bEnableShadowCasting_DEPRECATED;
        public FBool bRecomputeTangent_DEPRECATED;
        public FMeshUVChannelInfo UVChannelData;
        public FObjectPtr OverlayMaterialInterface;

        [Location("FArchive& operator<<(FArchive& Ar, FSkeletalMaterial& Elem)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref MaterialInterface);
            if (transfer.Supports.RefactorMeshEditorMaterials)
            {
                transfer.Move(ref MaterialSlotName);

                bSerializeImportedMaterialSlotName = true;
                if (transfer.Supports.SkeletalMaterialEditorDataStripping)
                {
                    transfer.Move(ref bSerializeImportedMaterialSlotName);
                }
                else if (transfer.GlobalObjects.IsFilterEditorOnly())
                {
                    bSerializeImportedMaterialSlotName = false;
                }
                if (bSerializeImportedMaterialSlotName)
                {
                    transfer.Move(ref ImportedMaterialSlotName);
                }
            }
            else
            {
                if (transfer.Supports.VER_UE4_MOVE_SKELETALMESH_SHADOWCASTING)
                {
                    transfer.Move(ref bEnableShadowCasting_DEPRECATED);
                }
                if (transfer.Supports.RuntimeRecomputeTangent)
                {
                    transfer.Move(ref bRecomputeTangent_DEPRECATED);
                }
            }
            if (transfer.Supports.TextureStreamingMeshUVChannelData)
            {
                transfer.Move(ref UVChannelData);
            }
            if (transfer.Supports.MeshMaterialSlotOverlayMaterialAdded)
            {
                transfer.Move(ref OverlayMaterialInterface);
            }
            return this;
        }
    }
}
