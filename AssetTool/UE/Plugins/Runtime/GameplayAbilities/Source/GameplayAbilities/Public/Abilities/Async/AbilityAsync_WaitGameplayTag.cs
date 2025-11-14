namespace AssetTool
{
    [JsonAsset("AbilityAsync_WaitGameplayTag")]
    public class UAbilityAsync_WaitGameplayTag : UAbilityAsync
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AbilityAsync_WaitGameplayTagAdded")]
    public class UAbilityAsync_WaitGameplayTagAdded : UAbilityAsync_WaitGameplayTag
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AbilityAsync_WaitGameplayTagRemoved")]
    public class UAbilityAsync_WaitGameplayTagRemoved : UAbilityAsync_WaitGameplayTag
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}