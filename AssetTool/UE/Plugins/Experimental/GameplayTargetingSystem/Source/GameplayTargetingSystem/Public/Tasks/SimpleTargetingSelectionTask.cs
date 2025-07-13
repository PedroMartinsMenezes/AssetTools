namespace AssetTool
{
    [JsonAsset("SimpleTargetingSelectionTask")]
    public class USimpleTargetingSelectionTask : UTargetingTask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}