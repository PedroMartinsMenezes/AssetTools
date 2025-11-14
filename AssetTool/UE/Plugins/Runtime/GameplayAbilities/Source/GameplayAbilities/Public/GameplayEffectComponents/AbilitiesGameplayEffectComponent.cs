namespace AssetTool
{
    [JsonAsset("AbilitiesGameplayEffectComponent")]
    public class UAbilitiesGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}