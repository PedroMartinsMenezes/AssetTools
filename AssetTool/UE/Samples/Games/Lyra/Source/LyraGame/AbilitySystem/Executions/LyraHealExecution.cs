namespace AssetTool
{
    [JsonAsset("LyraHealExecution")]
    public class ULyraHealExecution : UGameplayEffectExecutionCalculation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}