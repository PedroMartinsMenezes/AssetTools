namespace AssetTool
{
    [JsonAsset("ProxyMediaSource")]
    public class UProxyMediaSource : UMediaSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}