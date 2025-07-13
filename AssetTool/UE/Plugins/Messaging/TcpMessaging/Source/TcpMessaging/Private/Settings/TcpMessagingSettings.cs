namespace AssetTool
{
    [JsonAsset("TcpMessagingSettings")]
    public class UTcpMessagingSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}