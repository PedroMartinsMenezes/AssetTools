namespace AssetTool
{
    [JsonAsset("GameplayAbilityTargetActor")]
    public class AGameplayAbilityTargetActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}