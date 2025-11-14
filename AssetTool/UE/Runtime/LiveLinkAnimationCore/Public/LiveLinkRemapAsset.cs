namespace AssetTool
{
    [JsonAsset("LiveLinkRemapAsset")]
    public class ULiveLinkRemapAsset : ULiveLinkRetargetAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}