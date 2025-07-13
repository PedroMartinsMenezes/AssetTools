namespace AssetTool
{
    [JsonAsset("ProxyMediaOutput")]
    public class UProxyMediaOutput : UMediaOutput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}