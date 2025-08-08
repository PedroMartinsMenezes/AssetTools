namespace AssetTool
{
    [JsonAsset("EllipticalMovementPathPattern")]
    public class UEllipticalMovementPathPattern : UPathedMovementPatternBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}