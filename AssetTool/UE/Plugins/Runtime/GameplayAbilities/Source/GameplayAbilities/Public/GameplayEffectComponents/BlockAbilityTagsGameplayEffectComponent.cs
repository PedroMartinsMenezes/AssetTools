namespace AssetTool
{
    [JsonAsset("BlockAbilityTagsGameplayEffectComponent")]
    public class UBlockAbilityTagsGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}