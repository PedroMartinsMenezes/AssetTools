namespace AssetTool
{
    [JsonAsset("PointMovementPathPattern")]
    public class UPointMovementPathPattern : UPathedMovementPatternBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}