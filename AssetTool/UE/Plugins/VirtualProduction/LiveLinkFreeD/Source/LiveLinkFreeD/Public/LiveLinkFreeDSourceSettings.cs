namespace AssetTool
{
    [JsonAsset("LiveLinkFreeDSourceSettings")]
    public class ULiveLinkFreeDSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}