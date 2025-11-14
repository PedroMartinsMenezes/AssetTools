namespace AssetTool
{
    [JsonAsset("GameplayAbilityTargetActor_ActorPlacement")]
    public class AGameplayAbilityTargetActor_ActorPlacement : AGameplayAbilityTargetActor_GroundTrace
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}