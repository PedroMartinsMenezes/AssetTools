namespace AssetTool
{
    [JsonAsset("LiveLinkXRSourceFactory")]
    public class ULiveLinkXRSourceFactory : ULiveLinkSourceFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}