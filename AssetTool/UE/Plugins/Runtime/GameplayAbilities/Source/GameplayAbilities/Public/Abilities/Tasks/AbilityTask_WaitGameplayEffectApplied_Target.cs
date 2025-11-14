namespace AssetTool
{
    [JsonAsset("AbilityTask_WaitGameplayEffectApplied_Target")]
    public class UAbilityTask_WaitGameplayEffectApplied_Target : UAbilityTask_WaitGameplayEffectApplied
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}