namespace AssetTool
{
    [JsonAsset("LiveLinkXRSourceFactory")]
    public class ULiveLinkXRSourceFactory : ULiveLinkSourceFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}