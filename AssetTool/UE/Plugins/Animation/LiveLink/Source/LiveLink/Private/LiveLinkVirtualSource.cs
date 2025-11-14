namespace AssetTool
{
    [JsonAsset("LiveLinkVirtualSubjectSourceSettings")]
    public class ULiveLinkVirtualSubjectSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}