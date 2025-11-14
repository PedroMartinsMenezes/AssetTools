namespace AssetTool
{
    [JsonAsset("GameplayAbilityTargetActor_GroundTrace")]
    public class AGameplayAbilityTargetActor_GroundTrace : AGameplayAbilityTargetActor_Trace
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}