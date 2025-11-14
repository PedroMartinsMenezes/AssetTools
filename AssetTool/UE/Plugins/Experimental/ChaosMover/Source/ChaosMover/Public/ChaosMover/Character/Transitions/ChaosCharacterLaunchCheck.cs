namespace AssetTool
{
    [JsonAsset("ChaosCharacterLaunchCheck")]
    public class UChaosCharacterLaunchCheck : UChaosMovementModeTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}