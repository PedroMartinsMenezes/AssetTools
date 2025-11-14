namespace AssetTool
{
    [JsonAsset("LiveLinkFreeDSourceFactory")]
    public class ULiveLinkFreeDSourceFactory : ULiveLinkSourceFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}