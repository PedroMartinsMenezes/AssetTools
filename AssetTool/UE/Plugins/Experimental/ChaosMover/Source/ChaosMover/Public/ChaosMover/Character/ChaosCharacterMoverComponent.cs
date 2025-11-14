namespace AssetTool
{
    [JsonAsset("ChaosCharacterMoverComponent")]
    public class UChaosCharacterMoverComponent : UCharacterMoverComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}