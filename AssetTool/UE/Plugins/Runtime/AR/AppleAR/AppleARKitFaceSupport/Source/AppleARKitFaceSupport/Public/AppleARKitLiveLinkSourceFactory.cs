namespace AssetTool
{
    [JsonAsset("AppleARKitLiveLinkSourceFactory")]
    public class UAppleARKitLiveLinkSourceFactory : ULiveLinkSourceFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}