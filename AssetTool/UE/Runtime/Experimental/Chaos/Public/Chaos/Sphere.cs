namespace AssetTool.Chaos
{
    public class TSphere3 : FImplicitObject
    {
        public TVector3 Center;
        public float ArRadius;

        [Location("FORCEINLINE void SerializeImp(FArchive& Ar) at 271")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Center);
            transfer.Move(ref ArRadius);
            return this;
        }
    }
}
