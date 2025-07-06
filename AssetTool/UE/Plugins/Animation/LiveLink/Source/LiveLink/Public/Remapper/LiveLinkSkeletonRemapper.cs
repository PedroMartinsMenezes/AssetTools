namespace AssetTool
{
    [JsonAsset("LiveLinkSkeletonRemapper")]
    public class ULiveLinkSkeletonRemapper : ULiveLinkSubjectRemapper
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}