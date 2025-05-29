namespace AssetTool
{
    public partial class FImplicitObject : ITransferible
    {
        public FBool bIsConvex;
        public FBool bDoCollide;
        public Chaos.EImplicitObjectType CollisionType;

        [Location("void FImplicitObject::SerializeImp(FArchive& Ar)")]
        public virtual ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.ChaosArchiveAdded)
            {
                transfer.Move(ref bIsConvex);
                transfer.Move(ref bDoCollide);
            }
            if (transfer.SupportsAfter.CustomImplicitCollisionType)
            {
                CollisionType = (Chaos.EImplicitObjectType)transfer.Move((byte)CollisionType);
            }
            return this;
        }
    }
}
