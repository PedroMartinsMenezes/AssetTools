namespace AssetTool
{
    [JsonAsset("LiveLinkMasterLockitSourceSettings")]
    public class ULiveLinkMasterLockitSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}