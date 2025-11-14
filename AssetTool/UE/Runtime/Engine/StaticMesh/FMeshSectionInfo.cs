namespace AssetTool
{
    public class FMeshSectionInfo : ITransferable
    {
        public Int32 MaterialIndex;
        public FBool bEnableCollision;
        public FBool bCastShadow;

        [Location("FArchive& operator<<(FArchive& Ar, FMeshSectionInfo& Info)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref MaterialIndex);
            transfer.Move(ref bEnableCollision);
            transfer.Move(ref bCastShadow);
            return this;
        }
    }
}
