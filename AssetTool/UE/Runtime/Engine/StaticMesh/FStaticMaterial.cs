namespace AssetTool
{
    public class FStaticMaterial : ITransferible
    {
        public UInt32 MaterialInterface;
        public FName MaterialSlotName;
        public FName InImportedMaterialSlotName;
        public FMeshUVChannelInfo UVChannelData = new();

        [Location("FArchive& operator<<(FArchive& Ar, FStaticMaterial& Elem)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref MaterialInterface);
            transfer.Move(ref MaterialSlotName);
            transfer.Move(ref InImportedMaterialSlotName);
            UVChannelData.Move(transfer);
            return this;
        }
    }
}
