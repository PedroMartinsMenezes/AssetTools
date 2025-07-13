namespace AssetTool
{
    [JsonAsset("ImmunityGameplayEffectComponent")]
    public class UImmunityGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}