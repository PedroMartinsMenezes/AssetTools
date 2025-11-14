namespace AssetTool
{
    [JsonAsset("ChaosWalkingMode")]
    public class UChaosWalkingMode : UChaosCharacterMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}