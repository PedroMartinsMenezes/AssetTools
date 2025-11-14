namespace AssetTool
{
    [JsonAsset("LiveLinkSequencerSettings")]
    public class ULiveLinkSequencerSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}