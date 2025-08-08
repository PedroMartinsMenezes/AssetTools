namespace AssetTool
{
    [JsonAsset("ChaosCharacterFallingCheck")]
    public class UChaosCharacterFallingCheck : UChaosMovementModeTransition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}