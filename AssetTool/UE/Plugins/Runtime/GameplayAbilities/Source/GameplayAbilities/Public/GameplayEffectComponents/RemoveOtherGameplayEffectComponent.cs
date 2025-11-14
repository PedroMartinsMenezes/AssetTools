namespace AssetTool
{
    [JsonAsset("RemoveOtherGameplayEffectComponent")]
    public class URemoveOtherGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}