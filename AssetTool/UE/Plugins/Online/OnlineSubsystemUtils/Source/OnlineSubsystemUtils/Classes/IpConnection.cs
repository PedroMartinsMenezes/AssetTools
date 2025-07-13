namespace AssetTool
{
    [JsonAsset("IpConnection")]
    public class UIpConnection : UNetConnection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}