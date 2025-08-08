namespace AssetTool
{
    [JsonAsset("ChaosCharacterLaunchCheck")]
    public class UChaosCharacterLaunchCheck : UChaosMovementModeTransition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}