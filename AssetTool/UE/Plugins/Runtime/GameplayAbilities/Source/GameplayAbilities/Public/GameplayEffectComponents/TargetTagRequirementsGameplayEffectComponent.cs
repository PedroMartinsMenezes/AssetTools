namespace AssetTool
{
    [JsonAsset("TargetTagRequirementsGameplayEffectComponent")]
    public class UTargetTagRequirementsGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}