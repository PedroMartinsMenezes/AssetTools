namespace AssetTool
{
    [JsonAsset("GameplayAbilityTargetActor_Interact")]
    public class AGameplayAbilityTargetActor_Interact : AGameplayAbilityTargetActor_Trace
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}