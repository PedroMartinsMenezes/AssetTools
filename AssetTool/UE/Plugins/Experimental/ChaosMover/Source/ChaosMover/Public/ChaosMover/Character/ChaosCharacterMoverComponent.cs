namespace AssetTool
{
    [JsonAsset("ChaosCharacterMoverComponent")]
    public class UChaosCharacterMoverComponent : UCharacterMoverComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}