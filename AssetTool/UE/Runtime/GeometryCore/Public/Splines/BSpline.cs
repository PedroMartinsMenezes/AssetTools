namespace AssetTool
{
    public class TBSpline<T> : TSplineInterface where T : ITransferable, new()
    {
        public List<T> Values;
        public List<FKnot> PairKnots;
        public bool bIsClosedLoop;
        public bool bClampEnds;

        [Location("virtual bool Serialize(FArchive& Ar) override")]
        public override ITransferable Move(Transfer transfer)
        {
            if (base.Move(transfer) == null)
                return null;

            transfer.Move(ref Values);
            transfer.Move(ref PairKnots);
            transfer.Move(ref bIsClosedLoop);
            transfer.Move(ref bClampEnds);

            return this;
        }
    }

    public class FKnot : ITransferable
    {
        public float Value;
        public uint32 Multiplicity;

        [Location("friend FArchive& operator<<(FArchive& Ar, FKnot& Knot)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            transfer.Move(ref Multiplicity);
            return this;
        }
    }
}
