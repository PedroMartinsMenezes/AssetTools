namespace AssetTool
{
    [JsonAsset("TcpMessagingSettings")]
    public class UTcpMessagingSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}