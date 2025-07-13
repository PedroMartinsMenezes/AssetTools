namespace AssetTool
{
    [JsonAsset("GameplayEffectCustomApplicationRequirement")]
    public class UGameplayEffectCustomApplicationRequirement : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}