namespace AssetTool
{
    [JsonAsset("ChanceToApplyGameplayEffectComponent")]
    public class UChanceToApplyGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}