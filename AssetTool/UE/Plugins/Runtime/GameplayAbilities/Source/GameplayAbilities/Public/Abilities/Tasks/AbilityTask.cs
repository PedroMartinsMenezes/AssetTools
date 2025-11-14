namespace AssetTool
{
    [JsonAsset("AbilityTask")]
    public class UAbilityTask : UGameplayTask
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}