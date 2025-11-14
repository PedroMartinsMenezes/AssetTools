namespace AssetTool
{
    [JsonAsset("EllipticalMovementPathPattern")]
    public class UEllipticalMovementPathPattern : UPathedMovementPatternBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}