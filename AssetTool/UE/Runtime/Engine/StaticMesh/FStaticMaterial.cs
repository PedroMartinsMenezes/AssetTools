namespace AssetTool
{
    public class FStaticMaterial : ITransferible
    {
        public UInt32 MaterialInterface;
        public FName MaterialSlotName;
        public FName InImportedMaterialSlotName;
        public FMeshUVChannelInfo UVChannelData;
        public FObjectPtr OverlayMaterialInterface;

        [Location("FArchive& operator<<(FArchive& Ar, FStaticMaterial& Elem)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref MaterialInterface);
            transfer.Move(ref MaterialSlotName);
            if (!transfer.GlobalObjects.IsFilterEditorOnly())
            {
                transfer.Move(ref InImportedMaterialSlotName);
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
