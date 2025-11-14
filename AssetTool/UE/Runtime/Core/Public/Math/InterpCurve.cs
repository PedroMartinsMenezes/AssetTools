namespace AssetTool
{
    public class FInterpCurve<T> : ITransferable where T : ITransferable, new()
    {
        public List<FInterpCurvePoint<T>> Points;
        public bool bIsLooped;
        public float LoopKeyOffset;

        [Location("friend FArchive& operator<<( FArchive& Ar, FInterpCurve& Curve )")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Points);
            if (transfer.Supports.VER_UE4_INTERPCURVE_SUPPORTS_LOOPING)
            {
                transfer.Move(ref bIsLooped);
                transfer.Move(ref LoopKeyOffset);
            }
            return this;
        }
    }

    public class FInterpCurveFloat : FInterpCurve<TFloat>
    {
    }

    public class FInterpCurveVector2D : FInterpCurve<FVector2D>
    {
    }

    public class FInterpCurveVector : FInterpCurve<FVector>
    {
    }

    public class FInterpCurveQuat : FInterpCurve<FQuat>
    {
    }

    public class FInterpCurveTwoVectors : FInterpCurve<FTwoVectors>
    {
    }

    public class FInterpCurveLinearColor : FInterpCurve<FLinearColor>
    {
    }
}
