namespace AssetTool
{
    [JsonAsset("LyraDamageExecution")]
    public class ULyraDamageExecution : UGameplayEffectExecutionCalculation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}