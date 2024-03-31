namespace AssetTool
{
    [Location("FArchive& operator<<(FArchive& Ar, FMeshSectionInfo& Info)")]
    public class FMeshSectionInfo
    {
        public Int32 MaterialIndex;
        public FBool bEnableCollision;
        public FBool bCastShadow;

        public FMeshSectionInfo Read(BinaryReader reader)
        {
            reader.Read(ref MaterialIndex);
            reader.Read(ref bEnableCollision);
            reader.Read(ref bCastShadow);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(MaterialIndex);
            writer.Write(bEnableCollision);
            writer.Write(bCastShadow);
        }
    }
}
