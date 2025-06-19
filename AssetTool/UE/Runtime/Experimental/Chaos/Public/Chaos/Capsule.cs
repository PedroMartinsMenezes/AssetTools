namespace AssetTool.Chaos
{
    public class FCapsule : FImplicitObject
    {
        public TSegment MSegment;
        public float ArRadius;
        public SerializeAsAABB3 DummyBox;

        [Location("FORCEINLINE void SerializeImp(FArchive& Ar) at 389")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MSegment);
            transfer.Move(ref ArRadius);
            if (!transfer.Supports.CapsulesNoUnionOrAABBs)
            {
                transfer.Move(ref DummyBox);
            }
            return this;
        }
    }
}
