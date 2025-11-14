namespace AssetTool
{
    [JsonAsset("PlayerStateCountLimiterConfig")]
    public class UPlayerStateCountLimiterConfig : UNetObjectCountLimiterConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}