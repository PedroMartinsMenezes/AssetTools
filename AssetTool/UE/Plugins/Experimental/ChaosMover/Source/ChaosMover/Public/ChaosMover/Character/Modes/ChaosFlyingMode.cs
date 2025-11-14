namespace AssetTool
{
    [JsonAsset("ChaosFlyingMode")]
    public class UChaosFlyingMode : UChaosCharacterMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}