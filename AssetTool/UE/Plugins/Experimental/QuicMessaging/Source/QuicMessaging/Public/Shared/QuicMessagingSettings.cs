namespace AssetTool
{
    [JsonAsset("QuicMessagingSettings")]
    public class UQuicMessagingSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}