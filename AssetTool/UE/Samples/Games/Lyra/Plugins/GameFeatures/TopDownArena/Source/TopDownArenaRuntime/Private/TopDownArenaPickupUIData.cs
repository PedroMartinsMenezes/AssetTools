namespace AssetTool
{
    [JsonAsset("TopDownArenaPickupUIData")]
    public class UTopDownArenaPickupUIData : UGameplayEffectUIData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}