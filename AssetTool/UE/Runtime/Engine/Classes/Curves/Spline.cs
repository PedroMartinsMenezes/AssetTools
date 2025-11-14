namespace AssetTool
{
    [TransferableStruct("Spline")]
    public class FSpline : ITransferable
    {
        public int8 PreviousImpl;
        public FLegacySpline Data;

        [Location("bool FSpline::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            bool WasEnabled(int8 value) => value != 0;

            bool WasLegacy(int8 value) => value == 1;

            transfer.Move(ref PreviousImpl);

            if (WasEnabled(PreviousImpl))
            {
                if (WasLegacy(PreviousImpl))
                {
                    transfer.Move(ref Data);
                }
            }
            return this;
        }
    }

    public class FLegacySpline : ITransferable
    {
        public FInterpCurveVector PositionCurve;
        public FInterpCurveQuat RotationCurve;
        public FInterpCurveVector ScaleCurve;
        public FInterpCurveFloat ReparamTable;

        [Location("bool FLegacySpline::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref PositionCurve);
            transfer.Move(ref RotationCurve);
            transfer.Move(ref ScaleCurve);
            transfer.Move(ref ReparamTable);
            return this;
        }
    }
}
