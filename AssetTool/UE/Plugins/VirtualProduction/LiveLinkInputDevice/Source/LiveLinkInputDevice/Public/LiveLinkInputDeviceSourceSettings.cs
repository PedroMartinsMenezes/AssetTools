namespace AssetTool
{
    [JsonAsset("LiveLinkInputDeviceSourceSettings")]
    public class ULiveLinkInputDeviceSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}