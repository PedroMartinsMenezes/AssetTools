namespace AssetTool
{
    [JsonAsset("ProxyMediaSource")]
    public class UProxyMediaSource : UMediaSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}