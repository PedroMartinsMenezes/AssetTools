namespace AssetTool
{
    [JsonAsset("AsyncAction_PerformTargeting")]
    public class UAsyncAction_PerformTargeting : UBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}