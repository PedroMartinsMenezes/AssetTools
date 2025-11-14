namespace AssetTool
{
    [JsonAsset("SplineGeneratorBase")]
    public class USplineGeneratorBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CircleSplineGenerator")]
    public class UCircleSplineGenerator : USplineGeneratorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ArcSplineGenerator")]
    public class UArcSplineGenerator : USplineGeneratorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SquareSplineGenerator")]
    public class USquareSplineGenerator : USplineGeneratorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EllipseSplineGenerator")]
    public class UEllipseSplineGenerator : USplineGeneratorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RectangleSplineGenerator")]
    public class URectangleSplineGenerator : USplineGeneratorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LineSplineGenerator")]
    public class ULineSplineGenerator : USplineGeneratorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}