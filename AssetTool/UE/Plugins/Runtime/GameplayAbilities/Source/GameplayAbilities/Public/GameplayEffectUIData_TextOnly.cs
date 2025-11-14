namespace AssetTool
{
    [JsonAsset("GameplayEffectUIData_TextOnly")]
    public class UGameplayEffectUIData_TextOnly : UGameplayEffectUIData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}