namespace AssetTool
{
    [JsonAsset("GameplayEffectUIData_TextOnly")]
    public class UGameplayEffectUIData_TextOnly : UGameplayEffectUIData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}