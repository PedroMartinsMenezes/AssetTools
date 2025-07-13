namespace AssetTool
{
    [JsonAsset("SimpleTargetingSortTask")]
    public class USimpleTargetingSortTask : UTargetingSortTask_Base
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}