namespace AssetTool
{
    [JsonAsset("LiveLinkRemapAsset")]
    public class ULiveLinkRemapAsset : ULiveLinkRetargetAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}