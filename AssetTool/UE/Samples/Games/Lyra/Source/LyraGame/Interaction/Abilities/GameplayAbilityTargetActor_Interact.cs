namespace AssetTool
{
    [JsonAsset("GameplayAbilityTargetActor_Interact")]
    public class AGameplayAbilityTargetActor_Interact : AGameplayAbilityTargetActor_Trace
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}