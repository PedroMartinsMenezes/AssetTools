namespace AssetTool
{
    [JsonAsset("ChaosCharacterWaterCheck")]
    public class UChaosCharacterWaterCheck : UChaosMovementModeTransition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}