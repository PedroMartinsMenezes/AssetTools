namespace AssetTool
{
    [JsonAsset("AbilityTask")]
    public class UAbilityTask : UGameplayTask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}