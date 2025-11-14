namespace AssetTool
{
    [JsonAsset("ChaosCharacterFallingCheck")]
    public class UChaosCharacterFallingCheck : UChaosMovementModeTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}