namespace AssetTool
{
    [JsonAsset("LiveLinkPrestonMDRSourceSettings")]
    public class ULiveLinkPrestonMDRSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}