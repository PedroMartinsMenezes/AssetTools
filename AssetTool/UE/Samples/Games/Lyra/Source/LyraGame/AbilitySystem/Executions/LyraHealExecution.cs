namespace AssetTool
{
    [JsonAsset("LyraHealExecution")]
    public class ULyraHealExecution : UGameplayEffectExecutionCalculation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}