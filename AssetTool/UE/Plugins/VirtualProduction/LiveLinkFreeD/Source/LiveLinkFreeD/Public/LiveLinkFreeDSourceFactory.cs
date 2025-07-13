namespace AssetTool
{
    [JsonAsset("LiveLinkFreeDSourceFactory")]
    public class ULiveLinkFreeDSourceFactory : ULiveLinkSourceFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}