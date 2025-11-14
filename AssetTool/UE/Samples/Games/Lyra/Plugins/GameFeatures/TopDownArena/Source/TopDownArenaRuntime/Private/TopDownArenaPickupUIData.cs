namespace AssetTool
{
    [JsonAsset("TopDownArenaPickupUIData")]
    public class UTopDownArenaPickupUIData : UGameplayEffectUIData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}