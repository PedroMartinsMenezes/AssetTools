namespace AssetTool
{
    [JsonAsset("LiveLinkVirtualSubjectSourceSettings")]
    public class ULiveLinkVirtualSubjectSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}