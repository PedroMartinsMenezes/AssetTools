namespace AssetTool
{
    [JsonAsset("ChaosFallingMode")]
    public class UChaosFallingMode : UChaosCharacterMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}