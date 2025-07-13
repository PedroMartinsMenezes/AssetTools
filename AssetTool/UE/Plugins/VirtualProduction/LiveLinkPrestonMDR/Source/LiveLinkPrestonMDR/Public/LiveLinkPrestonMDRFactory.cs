namespace AssetTool
{
    [JsonAsset("LiveLinkPrestonMDRSourceFactory")]
    public class ULiveLinkPrestonMDRSourceFactory : ULiveLinkSourceFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}