namespace AssetTool
{
    [Location("void UStaticMesh::Serialize(FArchive& Ar)")]
    public class UStaticMesh : UStreamableRenderAsset
    {
        public const string TypeName = "StaticMesh";

        public new UStaticMesh Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
