namespace AssetTool
{
    [JsonAsset("AbilityTask_MoveToLocation")]
    public class UAbilityTask_MoveToLocation : UAbilityTask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}