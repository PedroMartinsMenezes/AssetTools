namespace AssetTool
{
    public static class FSplineTypeRegistry
    {
        public static ISplineInterface CreateSpline(uint32 TypeId)
        {
            if (TypeId == 1796568126)
                return new TTangentBezierSpline<FQuat4d>();
            else if (TypeId == 1796582690)
                return new TTangentBezierSpline<FVector3d>();
            else if (TypeId == 1796563493)
                return new TTangentBezierSpline<TFloat>();
            else if (TypeId == 3786648866)
                return new TMultiSpline<TTangentBezierSpline<FVector3d>>();
            else if (TypeId == 1424207138)
                return new TMultiSpline<TTangentBezierSpline<FVector3d>>();
            else
                throw new NotImplementedException();
        }
    }
}
