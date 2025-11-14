namespace AssetTool
{
    [JsonAsset("SharedChaosCharacterMovementSettings")]
    public class USharedChaosCharacterMovementSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}