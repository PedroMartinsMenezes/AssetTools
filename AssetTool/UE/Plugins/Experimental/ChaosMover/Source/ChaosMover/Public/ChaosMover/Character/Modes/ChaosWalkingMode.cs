namespace AssetTool
{
    [JsonAsset("ChaosWalkingMode")]
    public class UChaosWalkingMode : UChaosCharacterMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}