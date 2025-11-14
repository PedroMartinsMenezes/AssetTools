namespace AssetTool
{
    [JsonAsset("TargetTagRequirementsGameplayEffectComponent")]
    public class UTargetTagRequirementsGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}