namespace AssetTool
{
    [JsonAsset("ChaosCharacterLandingCheck")]
    public class UChaosCharacterLandingCheck : UChaosMovementModeTransition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}