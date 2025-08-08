namespace AssetTool
{
    [JsonAsset("PointMovementPathPattern")]
    public class UPointMovementPathPattern : UPathedMovementPatternBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}