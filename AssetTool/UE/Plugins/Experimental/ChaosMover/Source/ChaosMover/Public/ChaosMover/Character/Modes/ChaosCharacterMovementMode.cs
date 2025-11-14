namespace AssetTool
{
    [JsonAsset("ChaosCharacterMovementMode")]
    public class UChaosCharacterMovementMode : UChaosMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}