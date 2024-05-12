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
            var transfer = GlobalObjects.Transfer;
            transfer.Move(ref MaterialIndex);
            transfer.Move(ref bEnableCollision);
            transfer.Move(ref bCastShadow);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;
            transfer.Move(ref MaterialIndex);
            transfer.Move(ref bEnableCollision);
            transfer.Move(ref bCastShadow);
        }
    }
}
