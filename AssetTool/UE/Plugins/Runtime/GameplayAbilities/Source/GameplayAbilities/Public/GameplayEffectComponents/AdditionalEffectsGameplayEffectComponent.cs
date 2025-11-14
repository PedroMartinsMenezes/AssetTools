namespace AssetTool
{
    [JsonAsset("AdditionalEffectsGameplayEffectComponent")]
    public class UAdditionalEffectsGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}