namespace AssetTool
{
    public class FVertexFactoryTypeDependency : ITransferable
    {
        public FHashedName VertexFactoryTypeName;
        public FSHAHash VFSourceHash;

        [Location("friend FArchive& operator<<(FArchive& Ar,class FVertexFactoryTypeDependency& Ref)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref VertexFactoryTypeName);
            transfer.Move(ref VFSourceHash);
            return this;
        }
    }
}
