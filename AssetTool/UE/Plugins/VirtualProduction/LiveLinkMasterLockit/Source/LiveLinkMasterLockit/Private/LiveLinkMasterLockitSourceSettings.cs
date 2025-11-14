namespace AssetTool
{
    [JsonAsset("LiveLinkMasterLockitSourceSettings")]
    public class ULiveLinkMasterLockitSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}