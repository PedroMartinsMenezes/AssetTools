namespace AssetTool
{
    [JsonAsset("AbilityTask_WaitGameplayEffectApplied_Self")]
    public class UAbilityTask_WaitGameplayEffectApplied_Self : UAbilityTask_WaitGameplayEffectApplied
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}