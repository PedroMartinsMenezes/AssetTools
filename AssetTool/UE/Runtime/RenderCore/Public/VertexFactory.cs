namespace AssetTool
{
    public class FVertexFactoryTypeDependency : ITransferible
    {
        public FHashedName VertexFactoryTypeName;
        public FSHAHash VFSourceHash;

        [Location("friend FArchive& operator<<(FArchive& Ar,class FVertexFactoryTypeDependency& Ref)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref VertexFactoryTypeName);
            transfer.Move(ref VFSourceHash);
            return this;
        }
    }
}
