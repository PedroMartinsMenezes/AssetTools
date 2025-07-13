namespace AssetTool
{
    [JsonAsset("LiveLinkInputDeviceSourceSettings")]
    public class ULiveLinkInputDeviceSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}