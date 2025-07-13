namespace AssetTool
{
    [JsonAsset("AbilityTask_WaitMovementModeChange")]
    public class UAbilityTask_WaitMovementModeChange : UAbilityTask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}