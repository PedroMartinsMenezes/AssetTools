namespace AssetTool
{
    [JsonAsset("SimpleTargetingSortTask")]
    public class USimpleTargetingSortTask : UTargetingSortTask_Base
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}