namespace AssetTool
{
    [JsonAsset("ChaosMovementModeTransition")]
    public class UChaosMovementModeTransition : UBaseMovementModeTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}