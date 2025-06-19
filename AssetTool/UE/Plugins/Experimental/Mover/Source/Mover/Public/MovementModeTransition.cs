namespace AssetTool
{
    [JsonAsset("BaseMovementModeTransition")]
    public class UBaseMovementModeTransition : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}