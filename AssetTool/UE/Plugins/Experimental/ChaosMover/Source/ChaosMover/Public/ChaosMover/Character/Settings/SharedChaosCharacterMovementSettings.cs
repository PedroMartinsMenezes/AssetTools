namespace AssetTool
{
    [JsonAsset("SharedChaosCharacterMovementSettings")]
    public class USharedChaosCharacterMovementSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}