namespace AssetTool
{
    [JsonAsset("GameplayAbilityTargetActor_GroundTrace")]
    public class AGameplayAbilityTargetActor_GroundTrace : AGameplayAbilityTargetActor_Trace
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}