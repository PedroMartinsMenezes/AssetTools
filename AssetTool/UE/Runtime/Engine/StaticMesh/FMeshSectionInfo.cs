namespace AssetTool
{
    public class FMeshSectionInfo
    {
        public Int32 MaterialIndex;
        public FBool bEnableCollision;
        public FBool bCastShadow;

        [Location("FArchive& operator<<(FArchive& Ar, FMeshSectionInfo& Info)")]
        public FMeshSectionInfo Move(Transfer transfer)
        {
            transfer.Move(ref MaterialIndex);
            transfer.Move(ref bEnableCollision);
            transfer.Move(ref bCastShadow);
            return this;
        }
    }
}
