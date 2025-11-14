namespace AssetTool
{
    [JsonAsset("CustomCanApplyGameplayEffectComponent")]
    public class UCustomCanApplyGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}