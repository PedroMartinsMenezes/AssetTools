namespace AssetTool
{
    [JsonAsset("ArcRotationPattern")]
    public class UArcRotationPattern : UPathedMovementPatternBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}