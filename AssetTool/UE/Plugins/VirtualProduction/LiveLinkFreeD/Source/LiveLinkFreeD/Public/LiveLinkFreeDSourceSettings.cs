namespace AssetTool
{
    [JsonAsset("LiveLinkFreeDSourceSettings")]
    public class ULiveLinkFreeDSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}