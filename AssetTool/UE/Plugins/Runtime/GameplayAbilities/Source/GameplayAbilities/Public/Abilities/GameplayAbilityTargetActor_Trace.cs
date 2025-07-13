namespace AssetTool
{
    [JsonAsset("GameplayAbilityTargetActor_Trace")]
    public class AGameplayAbilityTargetActor_Trace : AGameplayAbilityTargetActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}