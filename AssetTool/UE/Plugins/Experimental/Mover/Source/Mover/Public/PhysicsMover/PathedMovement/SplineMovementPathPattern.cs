namespace AssetTool
{
    [JsonAsset("SplineMovementPathPattern")]
    public class USplineMovementPathPattern : UPathedMovementPatternBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}