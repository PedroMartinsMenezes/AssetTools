namespace AssetTool
{
    [JsonAsset("SimpleTargetingSelectionTask")]
    public class USimpleTargetingSelectionTask : UTargetingTask
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}