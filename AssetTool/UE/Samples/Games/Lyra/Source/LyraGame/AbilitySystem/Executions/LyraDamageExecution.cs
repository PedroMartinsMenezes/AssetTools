namespace AssetTool
{
    [JsonAsset("LyraDamageExecution")]
    public class ULyraDamageExecution : UGameplayEffectExecutionCalculation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}