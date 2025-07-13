namespace AssetTool
{
    [JsonAsset("BlockAbilityTagsGameplayEffectComponent")]
    public class UBlockAbilityTagsGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}