namespace AssetTool.Chaos
{
    public class TImplicitObjectScaled<T> : FImplicitObjectScaled where T : ITransferable, new()
    {
        public TRefCountPtr<T> MObject;
        public FVec3 MScale;
        public FVec3 MInvScale;
        public SerializeAsAABB3 MLocalBoundingBox;

        [Location("virtual void Serialize(FChaosArchive& Ar) override at 980")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MObject);
            transfer.Move(ref MScale);
            transfer.Move(ref MInvScale);
            transfer.Move(ref MLocalBoundingBox);
            return this;
        }
    }

    public class FImplicitObjectScaled : FImplicitObject
    {
    }

    public class TImplicitObjectInstanced<T> : FImplicitObjectInstanced where T : ITransferable, new()
    {
        public TRefCountPtr<T> MObject;

        [Location("virtual void Serialize(FChaosArchive& Ar) override at 133")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MObject);
            return this;
        }
    }

    public class FImplicitObjectInstanced : FImplicitObject
    {
    }
}
