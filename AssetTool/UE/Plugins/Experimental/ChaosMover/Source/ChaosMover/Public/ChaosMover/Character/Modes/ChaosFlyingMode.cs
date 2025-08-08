namespace AssetTool
{
    [JsonAsset("ChaosFlyingMode")]
    public class UChaosFlyingMode : UChaosCharacterMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}