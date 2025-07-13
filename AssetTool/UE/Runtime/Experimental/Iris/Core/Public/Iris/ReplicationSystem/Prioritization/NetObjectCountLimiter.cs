namespace AssetTool
{
    [JsonAsset("NetObjectCountLimiterConfig")]
    public class UNetObjectCountLimiterConfig : UNetObjectPrioritizerConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetObjectCountLimiter")]
    public class UNetObjectCountLimiter : UNetObjectPrioritizer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}