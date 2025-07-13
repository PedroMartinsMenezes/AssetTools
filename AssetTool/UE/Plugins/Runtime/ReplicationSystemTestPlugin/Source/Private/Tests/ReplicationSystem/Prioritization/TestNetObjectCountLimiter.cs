namespace AssetTool
{
    [JsonAsset("NetObjectCountLimiterFillTestConfig")]
    public class UNetObjectCountLimiterFillTestConfig : UNetObjectCountLimiterConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}