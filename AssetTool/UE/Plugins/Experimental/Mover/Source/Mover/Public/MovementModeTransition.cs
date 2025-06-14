namespace AssetTool
{
    [JsonAsset("BaseMovementModeTransition")]
    public class UBaseMovementModeTransition : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}