namespace AssetTool
{
    public class TSplineWrapper<SplineType> : TSplineInterface, ITransferable where SplineType : ITransferable, new()
    {
        public SplineType InternalSpline;

        [Location("virtual bool Serialize(FArchive& Ar) override")]
        public override ITransferable Move(Transfer transfer)
        {
            if (base.Move(transfer) == null)
                return null;

            transfer.Move(ref InternalSpline);

            return this;
        }
    }

    public class TMultiSpline<T> : TSplineWrapper<T> where T : ITransferable, new()
    {
        public Dictionary<FName, FChildSpline> Children;

        public override ITransferable Move(Transfer transfer)
        {
            if (base.Move(transfer) == null)
                return null;
            transfer.Move(ref Children);
            return this;
        }
    }

    public class FChildSpline : ITransferable
    {
        public EMappingRangeSpace MappingRangeSpace;
        public FInterval1f MappingRange;
        public ISplineInterface SplineType;
        public ISplineInterface Spline;

        [Location(88, "bool Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref MappingRangeSpace);
            transfer.Move(ref MappingRange);

            if (Spline is null)
            {
                transfer.Move(ref SplineType);
                Spline = FSplineTypeRegistry.CreateSpline(SplineType.TypeId);
                Spline.Version = SplineType.Version;
                Spline.TypeId = SplineType.TypeId;
            }

            Spline.Move(transfer);

            return this;
        }
    }

    public enum EMappingRangeSpace : uint8
    {
        Normalized,
        Parent
    }
}
