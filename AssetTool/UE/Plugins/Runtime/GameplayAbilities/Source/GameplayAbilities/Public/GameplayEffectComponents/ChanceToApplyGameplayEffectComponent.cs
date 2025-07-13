namespace AssetTool
{
    [JsonAsset("ChanceToApplyGameplayEffectComponent")]
    public class UChanceToApplyGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}