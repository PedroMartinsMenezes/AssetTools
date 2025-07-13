namespace AssetTool
{
    [JsonAsset("AssetTagsGameplayEffectComponent")]
    public class UAssetTagsGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}