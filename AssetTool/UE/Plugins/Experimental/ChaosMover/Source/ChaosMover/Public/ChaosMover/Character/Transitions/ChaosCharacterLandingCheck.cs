namespace AssetTool
{
    [JsonAsset("ChaosCharacterLandingCheck")]
    public class UChaosCharacterLandingCheck : UChaosMovementModeTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}