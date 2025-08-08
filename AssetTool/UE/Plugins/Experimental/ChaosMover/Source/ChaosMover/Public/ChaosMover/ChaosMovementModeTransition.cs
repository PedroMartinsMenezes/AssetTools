namespace AssetTool
{
    [JsonAsset("ChaosMovementModeTransition")]
    public class UChaosMovementModeTransition : UBaseMovementModeTransition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}