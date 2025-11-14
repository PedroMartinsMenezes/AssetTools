namespace AssetTool
{
    [JsonAsset("LookAtRotationPattern")]
    public class ULookAtRotationPattern : UPathedMovementPatternBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}