namespace AssetTool
{
    [JsonAsset("TargetTagsGameplayEffectComponent")]
    public class UTargetTagsGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}