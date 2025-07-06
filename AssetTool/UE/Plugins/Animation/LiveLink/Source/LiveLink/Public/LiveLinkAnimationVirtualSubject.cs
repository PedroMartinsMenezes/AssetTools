namespace AssetTool
{
    [JsonAsset("LiveLinkAnimationVirtualSubject")]
    public class ULiveLinkAnimationVirtualSubject : ULiveLinkVirtualSubject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}