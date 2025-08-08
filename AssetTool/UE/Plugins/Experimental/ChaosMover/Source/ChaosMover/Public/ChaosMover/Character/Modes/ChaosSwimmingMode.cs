namespace AssetTool
{
    [JsonAsset("ChaosSwimmingMode")]
    public class UChaosSwimmingMode : UChaosCharacterMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}