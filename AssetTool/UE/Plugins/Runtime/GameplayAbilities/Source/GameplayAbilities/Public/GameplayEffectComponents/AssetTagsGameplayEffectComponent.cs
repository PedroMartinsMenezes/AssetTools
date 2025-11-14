namespace AssetTool
{
    [JsonAsset("AssetTagsGameplayEffectComponent")]
    public class UAssetTagsGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}