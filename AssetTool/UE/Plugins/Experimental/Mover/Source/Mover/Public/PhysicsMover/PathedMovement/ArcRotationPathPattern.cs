namespace AssetTool
{
    [JsonAsset("ArcRotationPattern")]
    public class UArcRotationPattern : UPathedMovementPatternBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}