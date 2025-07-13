namespace AssetTool
{
    [JsonAsset("LiveLinkXRSourceSettings")]
    public class ULiveLinkXRSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}