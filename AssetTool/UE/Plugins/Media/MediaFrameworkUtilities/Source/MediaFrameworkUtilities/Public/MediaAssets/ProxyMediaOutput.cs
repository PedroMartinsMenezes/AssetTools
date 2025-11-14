namespace AssetTool
{
    [JsonAsset("ProxyMediaOutput")]
    public class UProxyMediaOutput : UMediaOutput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}