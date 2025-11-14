namespace AssetTool
{
    [JsonAsset("LiveLinkXRSourceSettings")]
    public class ULiveLinkXRSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}