namespace AssetTool
{
    [JsonAsset("GameplayTask_TimeLimitedExecution")]
    public class UGameplayTask_TimeLimitedExecution : UGameplayTask
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}