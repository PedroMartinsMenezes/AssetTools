namespace AssetTool
{
    [JsonAsset("LookAtRotationPattern")]
    public class ULookAtRotationPattern : UPathedMovementPatternBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}