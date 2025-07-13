namespace AssetTool
{
    [JsonAsset("QuicMessagingSettings")]
    public class UQuicMessagingSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}