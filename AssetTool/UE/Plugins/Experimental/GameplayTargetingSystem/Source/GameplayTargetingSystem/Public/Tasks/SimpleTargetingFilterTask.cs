namespace AssetTool
{
    [JsonAsset("SimpleTargetingFilterTask")]
    public class USimpleTargetingFilterTask : UTargetingFilterTask_BasicFilterTemplate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}