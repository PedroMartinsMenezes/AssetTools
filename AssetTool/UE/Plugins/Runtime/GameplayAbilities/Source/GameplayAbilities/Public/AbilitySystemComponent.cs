namespace AssetTool
{
    [JsonAsset("AbilitySystemComponent")]
    public class UAbilitySystemComponent : UGameplayTasksComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}