namespace AssetTool
{
    [JsonAsset("LiveLinkTransformRole")]
    public class ULiveLinkTransformRole : ULiveLinkBasicRole
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}