namespace AssetTool
{
    [JsonAsset("ImmunityGameplayEffectComponent")]
    public class UImmunityGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}