namespace AssetTool
{
    [JsonAsset("AbilityTask_MoveToLocation")]
    public class UAbilityTask_MoveToLocation : UAbilityTask
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}