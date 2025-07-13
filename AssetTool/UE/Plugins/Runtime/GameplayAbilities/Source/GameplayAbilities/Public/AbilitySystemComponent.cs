namespace AssetTool
{
    [JsonAsset("AbilitySystemComponent")]
    public class UAbilitySystemComponent : UGameplayTasksComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}