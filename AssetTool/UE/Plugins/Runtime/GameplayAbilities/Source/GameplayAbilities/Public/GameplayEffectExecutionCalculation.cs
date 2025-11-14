namespace AssetTool
{
    [JsonAsset("GameplayEffectExecutionCalculation")]
    public class UGameplayEffectExecutionCalculation : UGameplayEffectCalculation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}