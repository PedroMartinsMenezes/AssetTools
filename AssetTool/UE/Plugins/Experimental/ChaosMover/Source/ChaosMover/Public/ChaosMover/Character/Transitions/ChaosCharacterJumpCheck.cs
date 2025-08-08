namespace AssetTool
{
    [JsonAsset("ChaosCharacterJumpCheck")]
    public class UChaosCharacterJumpCheck : UChaosMovementModeTransition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}