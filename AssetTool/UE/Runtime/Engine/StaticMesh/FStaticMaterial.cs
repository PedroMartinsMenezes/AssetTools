namespace AssetTool
{
    public class FStaticMaterial
    {
        public UInt32 MaterialInterface;
        public FName MaterialSlotName;
        public FName InImportedMaterialSlotName;
        public FMeshUVChannelInfo UVChannelData = new();

        [Location("FArchive& operator<<(FArchive& Ar, FStaticMaterial& Elem)")]
        public FStaticMaterial Move(Transfer transfer)
        {
            transfer.Move(ref MaterialInterface);
            transfer.Move(ref MaterialSlotName);
            transfer.Move(ref InImportedMaterialSlotName);
            UVChannelData.Move(transfer);
            return this;
        }
    }
}
