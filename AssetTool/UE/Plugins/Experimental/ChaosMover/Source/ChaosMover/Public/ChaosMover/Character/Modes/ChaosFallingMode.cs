namespace AssetTool
{
    [JsonAsset("ChaosFallingMode")]
    public class UChaosFallingMode : UChaosCharacterMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}