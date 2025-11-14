namespace AssetTool
{
    [JsonAsset("ChaosSwimmingMode")]
    public class UChaosSwimmingMode : UChaosCharacterMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}