namespace AssetTool
{
    [JsonAsset("PlayerStateCountLimiterConfig")]
    public class UPlayerStateCountLimiterConfig : UNetObjectCountLimiterConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}