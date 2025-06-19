namespace AssetTool
{
    [JsonAsset("LiveLinkBasicRole")]
    public class ULiveLinkBasicRole : ULiveLinkRole
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}