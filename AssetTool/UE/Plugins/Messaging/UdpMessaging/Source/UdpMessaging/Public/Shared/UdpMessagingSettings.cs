namespace AssetTool
{
    [JsonAsset("UdpMessagingSettings")]
    public class UUdpMessagingSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}