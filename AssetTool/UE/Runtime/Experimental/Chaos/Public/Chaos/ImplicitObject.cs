namespace AssetTool
{
    public partial class FImplicitObject : ITransferible
    {
        public FBool bIsConvex;
        public FBool bDoCollide;
        public Chaos.EImplicitObjectType CollisionType;

        [Location("void FImplicitObject::SerializeImp(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (Supports.ChaosArchiveAdded)
            {
                transfer.Move(ref bIsConvex);
                transfer.Move(ref bDoCollide);
            }
            if (SupportsAfter.CustomImplicitCollisionType)
            {
                CollisionType = (Chaos.EImplicitObjectType)transfer.Move((byte)CollisionType);
            }
            return this;
        }
    }
}
