namespace AssetTool
{
    [JsonAsset("GameplayEffectUIData")]
    public class UGameplayEffectUIData : UGameplayEffectComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}