namespace AssetTool
{
    [JsonAsset("LiveLinkPrestonMDRSourceSettings")]
    public class ULiveLinkPrestonMDRSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}