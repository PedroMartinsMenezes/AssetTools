namespace AssetTool
{
    [JsonAsset("LiveLinkInputDeviceSourceFactory")]
    public class ULiveLinkInputDeviceSourceFactory : ULiveLinkSourceFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}