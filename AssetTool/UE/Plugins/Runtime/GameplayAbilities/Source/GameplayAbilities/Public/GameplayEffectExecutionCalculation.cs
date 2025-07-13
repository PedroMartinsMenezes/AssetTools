namespace AssetTool
{
    [JsonAsset("GameplayEffectExecutionCalculation")]
    public class UGameplayEffectExecutionCalculation : UGameplayEffectCalculation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}