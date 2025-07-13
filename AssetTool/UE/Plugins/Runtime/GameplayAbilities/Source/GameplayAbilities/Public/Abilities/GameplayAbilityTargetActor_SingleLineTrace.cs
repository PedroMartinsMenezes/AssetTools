namespace AssetTool
{
    [JsonAsset("GameplayAbilityTargetActor_SingleLineTrace")]
    public class AGameplayAbilityTargetActor_SingleLineTrace : AGameplayAbilityTargetActor_Trace
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}