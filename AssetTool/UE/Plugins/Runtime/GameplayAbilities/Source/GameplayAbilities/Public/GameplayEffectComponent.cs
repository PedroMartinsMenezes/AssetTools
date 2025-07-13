namespace AssetTool
{
    [JsonAsset("GameplayEffectComponent")]
    public class UGameplayEffectComponent : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}