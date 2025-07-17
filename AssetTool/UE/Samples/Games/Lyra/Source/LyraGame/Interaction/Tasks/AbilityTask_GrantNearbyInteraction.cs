namespace AssetTool
{
    [JsonAsset("AbilityTask_GrantNearbyInteraction")]
    public class UAbilityTask_GrantNearbyInteraction : UAbilityTask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}