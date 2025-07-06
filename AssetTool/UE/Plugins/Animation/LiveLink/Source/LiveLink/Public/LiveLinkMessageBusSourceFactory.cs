namespace AssetTool
{
    [JsonAsset("LiveLinkMessageBusSourceFactory")]
    public class ULiveLinkMessageBusSourceFactory : ULiveLinkSourceFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}