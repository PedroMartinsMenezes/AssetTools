namespace AssetTool
{
    [JsonAsset("AbilitiesGameplayEffectComponent")]
    public class UAbilitiesGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}