namespace AssetTool
{
    [JsonAsset("NetObjectCountLimiterFillTestConfig")]
    public class UNetObjectCountLimiterFillTestConfig : UNetObjectCountLimiterConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}