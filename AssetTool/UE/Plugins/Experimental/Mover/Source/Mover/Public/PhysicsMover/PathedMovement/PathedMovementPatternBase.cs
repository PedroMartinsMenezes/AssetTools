namespace AssetTool
{
    [JsonAsset("PathedMovementPatternBase")]
    public class UPathedMovementPatternBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}