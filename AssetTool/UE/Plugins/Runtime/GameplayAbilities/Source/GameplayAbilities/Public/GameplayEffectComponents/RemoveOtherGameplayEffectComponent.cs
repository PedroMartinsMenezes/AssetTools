namespace AssetTool
{
    [JsonAsset("RemoveOtherGameplayEffectComponent")]
    public class URemoveOtherGameplayEffectComponent : UGameplayEffectComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}