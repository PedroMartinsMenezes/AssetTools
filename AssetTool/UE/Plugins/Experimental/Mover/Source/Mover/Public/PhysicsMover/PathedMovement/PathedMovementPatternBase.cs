namespace AssetTool
{
    [JsonAsset("PathedMovementPatternBase")]
    public class UPathedMovementPatternBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}