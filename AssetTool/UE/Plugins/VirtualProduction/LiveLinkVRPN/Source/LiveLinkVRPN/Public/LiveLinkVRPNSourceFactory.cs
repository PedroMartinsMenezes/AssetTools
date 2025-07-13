namespace AssetTool
{
    [JsonAsset("LiveLinkVRPNSourceFactory")]
    public class ULiveLinkVRPNSourceFactory : ULiveLinkSourceFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}