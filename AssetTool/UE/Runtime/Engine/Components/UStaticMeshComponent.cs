namespace AssetTool
{
    [Location("void UStaticMeshComponent::Serialize(FArchive& Ar)")]
    public class UStaticMeshComponent : UMeshComponent
    {
        public new const string TypeName = "StaticMeshComponent";

        public List<FStaticMeshComponentLODInfo> LODData = [];

        public new UStaticMeshComponent Read(BinaryReader reader)
        {
            base.Read(reader);

            LODData.Resize(reader.ReadInt32());

            LODData.ForEach(x => x.Read(reader));

            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);

            writer.Write(LODData.Count);

            LODData.ForEach(x => FStaticMeshComponentLODInfo.Write(writer));
        }
    }
}
