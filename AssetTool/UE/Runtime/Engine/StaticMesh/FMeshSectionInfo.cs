namespace AssetTool
{
    public class FMeshSectionInfo : ITransferible
    {
        public Int32 MaterialIndex;
        public FBool bEnableCollision;
        public FBool bCastShadow;

        [Location("FArchive& operator<<(FArchive& Ar, FMeshSectionInfo& Info)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref MaterialIndex);
            transfer.Move(ref bEnableCollision);
            transfer.Move(ref bCastShadow);
            return this;
        }
    }
}
