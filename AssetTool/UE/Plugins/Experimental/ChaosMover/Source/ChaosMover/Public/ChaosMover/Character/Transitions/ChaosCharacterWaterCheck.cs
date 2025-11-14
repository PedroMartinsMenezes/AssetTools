namespace AssetTool
{
    [JsonAsset("ChaosCharacterWaterCheck")]
    public class UChaosCharacterWaterCheck : UChaosMovementModeTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}