namespace AssetTool
{
    [JsonAsset("GameplayEffectUIData")]
    public class UGameplayEffectUIData : UGameplayEffectComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}