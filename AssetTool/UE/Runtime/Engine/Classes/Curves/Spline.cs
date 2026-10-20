namespace AssetTool
{
    [TransferableStruct("Spline")]
    public class FSpline : ITransferable
    {
        private readonly uint8 CurrentImplementation = 0;
        public int8 PreviousImpl;
        public FLegacySpline LegacyData;
        public FNewSpline NewData;

        private static bool WasEnabled(int8 value) => value != 0;
        private static bool WasLegacy(int8 value) => value == 1;
        private bool IsEnabled() { return CurrentImplementation != 0; }
        private bool IsLegacy() { return CurrentImplementation == 1; }
        private bool IsNew() { return CurrentImplementation == 2; }

        [Location("bool FSpline::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref PreviousImpl);
            if (WasEnabled(PreviousImpl))
            {
                if (WasLegacy(PreviousImpl))
                {
                    if (IsLegacy() || IsNew() || !IsEnabled())
                    {
                        transfer.Move(ref LegacyData);
                    }
                }
                else
                {
                    if (IsLegacy() || IsNew() || !IsEnabled())
                    {
                        transfer.Move(ref NewData);
                    }
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

    public class FNewSpline : TMultiSpline<TTangentBezierSpline<FVector3d>>
    {
        public int32 ReparamStepsPerSegment;

        [Location("bool FNewSpline::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref ReparamStepsPerSegment);
            return this;
        }
    }
}
