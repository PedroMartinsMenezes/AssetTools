namespace AssetTool
{
    public class FImplicitObjectUnion : FImplicitObject
    {
        public List<TRefCountPtr<FImplicitObject>> MObjects;

        [Location("void FImplicitObjectUnion::Serialize(FChaosArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MObjects);//17721
            //TBox<FReal, 3>::SerializeAsAABB(Ar, MLocalBoundingBox); //17745
            throw new NotImplementedException();
        }
    }

    public class FImplicitObjectUnionClustered : FImplicitObjectUnion
    {
        public override ITransferible Move(Transfer transfer)
        {
            return this;
        }
    }
}
