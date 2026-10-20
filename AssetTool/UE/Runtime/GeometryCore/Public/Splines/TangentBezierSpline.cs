namespace AssetTool
{
    public class TTangentBezierSpline<T> : TSplineWrapper<TPolyBezierSpline<T>> where T : ITransferable, new()
    {
        public float Tension;
        public List<TUInt8> TangentModes;
        public bool bStationaryEndpoint;

        [Location("virtual bool Serialize(FArchive& Ar) override")]
        public override ITransferable Move(Transfer transfer)
        {
            if (base.Move(transfer) == null)
                return null;

            transfer.Move(ref Tension);
            transfer.Move(ref TangentModes);
            transfer.Move(ref bStationaryEndpoint);

            return this;
        }
    }
}