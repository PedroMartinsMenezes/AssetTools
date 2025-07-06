namespace AssetTool
{
    [JsonAsset("LiveLinkMessageBusSourceSettings")]
    public class ULiveLinkMessageBusSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}