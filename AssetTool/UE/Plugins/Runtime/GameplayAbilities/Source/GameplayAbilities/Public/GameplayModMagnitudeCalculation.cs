namespace AssetTool
{
    [JsonAsset("GameplayModMagnitudeCalculation")]
    public class UGameplayModMagnitudeCalculation : UGameplayEffectCalculation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}