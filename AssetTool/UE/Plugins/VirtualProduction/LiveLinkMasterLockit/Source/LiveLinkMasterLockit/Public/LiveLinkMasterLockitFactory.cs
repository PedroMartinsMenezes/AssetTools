namespace AssetTool
{
    [JsonAsset("LiveLinkMasterLockitSourceFactory")]
    public class ULiveLinkMasterLockitSourceFactory : ULiveLinkSourceFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}