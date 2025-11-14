namespace AssetTool
{
    [JsonAsset("TargetTagsGameplayEffectComponent")]
    public class UTargetTagsGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}