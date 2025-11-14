namespace AssetTool
{
    [JsonAsset("LiveLinkMessageBusSourceSettings")]
    public class ULiveLinkMessageBusSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}