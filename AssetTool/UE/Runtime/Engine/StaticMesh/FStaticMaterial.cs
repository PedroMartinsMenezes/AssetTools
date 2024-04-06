namespace AssetTool
{
    [Location("FArchive& operator<<(FArchive& Ar, FStaticMaterial& Elem)")]
    public class FStaticMaterial
    {
        public const string StructName = "StaticMaterial";

        public UInt32 MaterialInterface;
        public FName MaterialSlotName;
        public FName InImportedMaterialSlotName;
        public FMeshUVChannelInfo UVChannelData;

        public FStaticMaterial Read(BinaryReader reader)
        {
            reader.Read(ref MaterialInterface);
            reader.Read(ref MaterialSlotName);
            reader.Read(ref InImportedMaterialSlotName);
            UVChannelData = new FMeshUVChannelInfo().Read(reader);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(MaterialInterface);
            writer.Write(MaterialSlotName);
            writer.Write(InImportedMaterialSlotName);
            UVChannelData.Write(writer);
        }
    }
}
