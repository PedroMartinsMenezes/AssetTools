namespace AssetTool
{
    [JsonAsset("CustomCanApplyGameplayEffectComponent")]
    public class UCustomCanApplyGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}