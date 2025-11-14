namespace AssetTool
{
    [JsonAsset("LiveLinkBasicRole")]
    public class ULiveLinkBasicRole : ULiveLinkRole
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}