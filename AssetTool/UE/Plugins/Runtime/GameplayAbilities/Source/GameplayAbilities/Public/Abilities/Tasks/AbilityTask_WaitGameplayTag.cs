namespace AssetTool
{
    [JsonAsset("AbilityTask_WaitGameplayTagAdded")]
    public class UAbilityTask_WaitGameplayTagAdded : UAbilityTask_WaitGameplayTag
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AbilityTask_WaitGameplayTagRemoved")]
    public class UAbilityTask_WaitGameplayTagRemoved : UAbilityTask_WaitGameplayTag
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}