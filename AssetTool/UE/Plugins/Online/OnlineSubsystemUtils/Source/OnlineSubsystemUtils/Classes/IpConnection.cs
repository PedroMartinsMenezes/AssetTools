namespace AssetTool
{
    [JsonAsset("IpConnection")]
    public class UIpConnection : UNetConnection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}