namespace AssetTool
{
    [JsonAsset("ChaosCharacterJumpCheck")]
    public class UChaosCharacterJumpCheck : UChaosMovementModeTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}