namespace AssetTool
{
    [JsonAsset("AdditionalEffectsGameplayEffectComponent")]
    public class UAdditionalEffectsGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}