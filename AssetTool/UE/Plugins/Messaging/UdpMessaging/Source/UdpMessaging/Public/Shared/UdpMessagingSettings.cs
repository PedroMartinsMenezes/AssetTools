namespace AssetTool
{
    [JsonAsset("UdpMessagingSettings")]
    public class UUdpMessagingSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}