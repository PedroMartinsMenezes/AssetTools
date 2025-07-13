namespace AssetTool
{
    [JsonAsset("SplineGeneratorBase")]
    public class USplineGeneratorBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CircleSplineGenerator")]
    public class UCircleSplineGenerator : USplineGeneratorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ArcSplineGenerator")]
    public class UArcSplineGenerator : USplineGeneratorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SquareSplineGenerator")]
    public class USquareSplineGenerator : USplineGeneratorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EllipseSplineGenerator")]
    public class UEllipseSplineGenerator : USplineGeneratorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RectangleSplineGenerator")]
    public class URectangleSplineGenerator : USplineGeneratorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LineSplineGenerator")]
    public class ULineSplineGenerator : USplineGeneratorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}