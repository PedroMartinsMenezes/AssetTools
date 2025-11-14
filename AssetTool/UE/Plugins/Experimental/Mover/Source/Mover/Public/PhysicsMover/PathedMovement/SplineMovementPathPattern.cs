namespace AssetTool
{
    [JsonAsset("SplineMovementPathPattern")]
    public class USplineMovementPathPattern : UPathedMovementPatternBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}